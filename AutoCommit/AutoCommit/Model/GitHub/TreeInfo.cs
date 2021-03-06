﻿using Newtonsoft.Json;

namespace AutoCommit.Model.GitHub
{
    public class TreeInfo : ShaInfo
    {
        private const string BlobMode = "100644";
        private const string BlobType = "blob";

        [JsonProperty("mode")]
        public string Mode => BlobMode;

        [JsonProperty("path")]
        public string Path
        {
            get;
        }

        [JsonProperty("type")]
        public string Type => BlobType;

        public TreeInfo(string safePath, string blobUploadSha)
        {
            Path = safePath;
            Sha = blobUploadSha;
        }
    }
}