﻿namespace FileManager.Domain.Entities
{
    public class FileRecordInfo : BaseEntity
    {
        public string Name { get; protected set; }
        public string ContentType { get; protected set; }
        public string Identity { get; protected set; }
        public virtual User.User User { get; protected set; }
        public long UserId { get; set; }
        public string Path { get; protected set; }
        public double Size { get; protected set; }

        protected FileRecordInfo()
        {
        }

        public FileRecordInfo(string identity, User.User user, string name, string contentType, string path, double size)
        {
            Identity = identity;
            User = user;
            Name = name;
            ContentType = contentType;
            Path = path;
            Size = size;
        }
    }
}