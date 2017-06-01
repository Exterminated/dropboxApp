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
        private static string _TOKEN = "qiT0iqau8qwAAAAAAAASzDQBk4nuH30N77_wmKgniUXccmvF3I1JeRDcn6geYrQD";
        private string _PATH = @"";
        private DropboxClient _DBX = new DropboxClient(_TOKEN);

        public string PATH { get => _PATH; set => _PATH = value; }

        public Dropbox() { }
        
        public string Connect() {
            var task = Task.Run(Connect_Task);
            task.Wait();
            return task.Result;
        }
        public List<string> All_Files() {
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
        public void Download(string folder_d, string file_d) {
            var task = Task.Run(()=>Download_Task(folder_d, file_d));
            task.Wait();
        }
        public void Upload(string folder_d, string file_d, string content_d) {
            var task = Task.Run(() => Upload_Task(folder_d, file_d, content_d));
            task.Wait(); 
        }
        private async Task <String> Connect_Task()
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
            using (_DBX)
                return await _DBX.Files.ListFolderAsync(string.Empty);
        }
        private async Task Download_Task( string folder, string file)
        {
            using (var response = await _DBX.Files.DownloadAsync(folder + "/" + file))
            {
                await response.GetContentAsStringAsync();
            }
        }
        private async Task Upload_Task(string folder, string file, string content)
        {
            var mem = new MemoryStream(Encoding.UTF8.GetBytes(content));
            
            var updated = await _DBX.Files.UploadAsync(
                folder + "/" + file,
                WriteMode.Overwrite.Instance,
                body: mem);            
        }
    }
}
