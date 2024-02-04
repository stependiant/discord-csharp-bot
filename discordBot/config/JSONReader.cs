using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace discordBot.config
{
    internal class JSONReader
    {
        public string token {  get; set; }
        public string prefix { get; set; }
        public async Task ReadJSON()
        {
            using (StreamReader streamReader = new StreamReader("config.json", new UTF8Encoding(false)))
            {
                string json = await streamReader.ReadToEndAsync();
                JSONStructure data = JsonConvert.DeserializeObject<JSONStructure>(json);
            
                this.token = data.Token;
                this.prefix = data.Prefix;
            }
        }
    }

    internal sealed class JSONStructure
    {
        public string Token { get; set; }
        public string Prefix { get; set; }
    }
}
