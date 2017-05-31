using Dropbox.Api;
using Dropbox.Api.Files;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace dropboxApp
{
    class Dropbox
    {
        private string _TOKEN = "qiT0iqau8qwAAAAAAAASzDQBk4nuH30N77_wmKgniUXccmvF3I1JeRDcn6geYrQD";
        private string _PATH = @"";

        public Dropbox() { }

        public string connect() {
            var task = Task.Run(Connect);
            task.Wait();
            return task.Result;
        }
        public List<string> all_Files() {
            List<string> files = new List<string>();
            var task = Task.Run(Files);
            task.Wait();
            var downloaded_files = task.Result;
            foreach (var item in downloaded_files.Entries) {
                if (item.IsFolder) files.Add(item.Name.ToString());
            }
            foreach (var item in downloaded_files.Entries) {
                if(item.IsFile) files.Add(item.Name.ToString());
            }
            return files;
        }
        private async Task <String>Connect()
        {
            string result;
            using (var dbx = new DropboxClient(_TOKEN))
            {
                var full = await dbx.Users.GetCurrentAccountAsync();
                result = full.Name.DisplayName.ToString() +" "+ full.Email.ToString();
            }
            return result;
        }
        private async Task <ListFolderResult>Files(){
            using (var dbx = new DropboxClient(_TOKEN))
                return await dbx.Files.ListFolderAsync(string.Empty);
        }
        private async Task Download(DropboxClient dbx, string folder, string file)
        {
            using (var response = await dbx.Files.DownloadAsync(folder + "/" + file))
            {
                //Console.WriteLine(await response.GetContentAsStringAsync());
            }
        }
        private async Task Upload(DropboxClient dbx, string folder, string file, string content)
        {
            using (var mem = new MemoryStream(Encoding.UTF8.GetBytes(content)))
            {
                var updated = await dbx.Files.UploadAsync(
                    folder + "/" + file,
                    WriteMode.Overwrite.Instance,
                    body: mem);
                //Console.WriteLine("Saved {0}/{1} rev {2}", folder, file, updated.Rev);
            }
        }
    }
}
