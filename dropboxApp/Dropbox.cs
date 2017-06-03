using Dropbox.Api;
using Dropbox.Api.Files;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace dropboxApp
{
    class Dropbox
    {
        private static string _TOKEN = "qiT0iqau8qwAAAAAAAASzDQBk4nuH30N77_wmKgniUXccmvF3I1JeRDcn6geYrQD";
        private string _PATH = @"";

        public string PATH { get => _PATH; set => _PATH = value; }

        public Dropbox() { }
        
        public string Connect() {
            var task = Task.Run(Connect_Task);
            task.Wait();
            return task.Result;
        }
        public List<string> All_Files() {
            List<string> all_cloud_items = new List<string>();
            var task = Task.Run(Files);
            task.Wait();
            var downloaded_files = task.Result;
            foreach (var item in downloaded_files.Entries) {
                if (item.IsFolder) all_cloud_items.Add(item.Name.ToString());
            }
            foreach (var item in downloaded_files.Entries) {
                if(item.IsFile) all_cloud_items.Add(item.Name.ToString());
            }
            return all_cloud_items;
        }
        public Stream Download(string folder_d, string file_d) {
            var task = Task.Run(()=>Download_Task(folder_d, file_d));
            task.Wait();
            return task.Result;
        }
        public void Upload(string folder_u, string file_u) {
            string file_name = Path.GetFileName(file_u);
            MemoryStream content_u = new MemoryStream(File.ReadAllBytes(file_u));
            var task = Task.Run(() => Upload_Task(folder_u, file_name, content_u));
            task.Wait();
        }
        private async Task <String> Connect_Task()
        {
            string result;
            using (var dbx = new DropboxClient(_TOKEN))
            {
                var full = await dbx.Users.GetCurrentAccountAsync();
                result = full.Name.DisplayName.ToString() +"\n"+ full.Email.ToString();
            }
            return result;
        }
        private async Task <ListFolderResult> Files(){
            DropboxClient dbx = new DropboxClient(_TOKEN);            
            return await dbx.Files.ListFolderAsync(string.Empty);
        }
        private async Task <Stream> Download_Task(string folder, string file)
        {
            DropboxClient dbx = new DropboxClient(_TOKEN);
            Stream file_cloud;

            var response = await dbx.Files.DownloadAsync("/" + folder + "/" + file);           
            //await response.GetContentAsStringAsync();
            file_cloud = await response.GetContentAsStreamAsync();            
            return file_cloud;
        }
        private async Task Upload_Task(string folder, string file, MemoryStream mem)
        {
            DropboxClient dbx = new DropboxClient(_TOKEN);

            var updated = await dbx.Files.UploadAsync(
            "/" + folder + "/" + file,
            WriteMode.Overwrite.Instance,
            true,
            null,
            false,
            mem);
        }
    }
}
