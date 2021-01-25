﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BakalariClient.Models;
using Newtonsoft.Json;

namespace BakalariClient.Services
{
    class CredentialReaderService
    {
        private readonly string filename;
        public CredentialReaderService(string filename)
        {
            this.filename = filename;
        }

        /// <summary>
        /// Read file and return contents
        /// </summary>
        /// <returns></returns>
        public Credential GetCredentialsFromFile()
        {
            return JsonConvert.DeserializeObject<Credential>(File.ReadAllText(filename));
        }
    }
}