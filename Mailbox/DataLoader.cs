using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Mailbox
{
    public class DataLoader : IDisposable
    {
        private bool Disposed { get; set; }
        private Stream Source { get; }

        public DataLoader(Stream source)
        {
            Source = source ?? throw new ArgumentNullException(nameof(source));
            if (!source.CanSeek)
            {
                throw new ArgumentException("Stream should be seekable", nameof(source));
            }
        }

        public List<Mailbox> Load()
        {
            Source.Position = 0;
            using var reader = new StreamReader(Source, leaveOpen: true);
            string jsonString = reader.ReadToEnd();
            return JsonConvert.DeserializeObject<List<Mailbox>>(jsonString);
        }

        public void Save(List<Mailbox> mailboxes)
        {
            Source.Position = 0;
            using var writer = new StreamWriter(Source, leaveOpen: true);
            string jsonString = JsonConvert.SerializeObject(mailboxes);
            writer.Write(jsonString);
        }

        ~DataLoader()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            // Dispose of unmanaged resources.
            Dispose(true);
            // Suppress finalization.
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (Disposed)
            {
                return;
            }
            if (disposing)
            {
                Source.Dispose();
            }
            Disposed = true;
        }
    }
}
