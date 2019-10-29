using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Mailbox.Tests
{
    [TestClass]
    public class DataLoaderTests
    {
        [ExpectedException(typeof(ArgumentNullException))]
        [TestMethod]
        public void Constructor_RequiresStream()
        {
            using var _ = new DataLoader(null);
        }

        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void Constructor_RequiresSeekableStream()
        {
            using var _ = new DataLoader(new NonSeekableStream());
        }

        [TestMethod]
        public void Dispose_DisposesStream()
        {
            using var stream = new TestableStream();
            using var dataLoader = new DataLoader(stream);

            dataLoader.Dispose();

            Assert.AreEqual(1, stream.DisposedCount);
        }

        [TestMethod]
        public void Dispose_CanBeCalledMultipleTimes()
        {
            using var stream = new TestableStream();
            using var dataLoader = new DataLoader(stream);

            dataLoader.Dispose();
            dataLoader.Dispose();

            Assert.AreEqual(1, stream.DisposedCount);
        }

        [TestMethod]
        public void Load_RetrievesMailboxes()
        {
            using var stream = new MemoryStream();
            using var dataLoader = new DataLoader(stream);
            var mailboxes = new List<Mailbox>
            {
                new Mailbox((1, 2), Sizes.Small, new Person { FirstName = "Kevin", LastName = "Bost" })
            };
            using var writer = new StreamWriter(stream, leaveOpen:true);
            writer.Write(JsonConvert.SerializeObject(mailboxes));
            writer.Flush();

            List<Mailbox> loadedMailboxes = dataLoader.Load();

            Assert.AreEqual(1, loadedMailboxes.Count);
            Assert.AreEqual(mailboxes[0].Size, loadedMailboxes[0].Size);
            Assert.AreEqual(mailboxes[0].Location, loadedMailboxes[0].Location);
            Assert.AreEqual(mailboxes[0].Owner, loadedMailboxes[0].Owner);
        }

        [TestMethod]
        public void Save_WritesDataToStream()
        {
            using var stream = new MemoryStream();
            using var dataLoader = new DataLoader(stream);
            var mailboxes = new List<Mailbox>
            {
                new Mailbox((1, 2), Sizes.Small, new Person { FirstName = "Kevin", LastName = "Bost" })
            };

            dataLoader.Save(mailboxes);

            stream.Position = 0;
            using var reader = new StreamReader(stream, leaveOpen:true);
            string data = reader.ReadToEnd();
            Assert.AreEqual(JsonConvert.SerializeObject(mailboxes), data);
        }


        private class TestableStream : MemoryStream
        {
            public int DisposedCount { get; set; }
            protected override void Dispose(bool disposing)
            {
                DisposedCount++;
                base.Dispose(disposing);
            }
        }

        private class NonSeekableStream : Stream
        {
            public override bool CanRead => throw new NotImplementedException();

            public override bool CanSeek => false;

            public override bool CanWrite => throw new NotImplementedException();

            public override long Length => throw new NotImplementedException();

            public override long Position { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            public override void Flush()
            {
                throw new NotImplementedException();
            }

            public override int Read(byte[] buffer, int offset, int count)
            {
                throw new NotImplementedException();
            }

            public override long Seek(long offset, SeekOrigin origin)
            {
                throw new NotImplementedException();
            }

            public override void SetLength(long value)
            {
                throw new NotImplementedException();
            }

            public override void Write(byte[] buffer, int offset, int count)
            {
                throw new NotImplementedException();
            }

            public bool IsDisposed { get; set; }
            protected override void Dispose(bool disposing)
            {
                base.Dispose(disposing);
            }
        }
    }
}
