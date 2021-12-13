using System.Collections.Generic;
using System.Linq;

namespace LeetCode.HashTable.Hard.DesignInMemoryFileSystem
{
    //https://leetcode.com/problems/design-in-memory-file-system/
    internal class FileSystemItem
    {
        public string Content;
        public bool IsFile = false;
        public Dictionary<string, FileSystemItem> Items = new();
    }

    public class FileSystem
    {
        private FileSystemItem _fileSystemItem;

        public FileSystem()
        {
            _fileSystemItem = new FileSystemItem();
        }

        public IList<string> Ls(string path)
        {
            if (!_fileSystemItem.Items.Any()) return new List<string>();

            var pathArray = path == "/" ? new []{""} : path.Split("/");

            var head = _fileSystemItem;
            foreach (var pathItem in pathArray)
            {
                head = head.Items[pathItem];
            }

            if (head.IsFile) return new List<string> {pathArray[pathArray.Length - 1]};

            return head.Items.Keys.OrderBy(x => x).ToList();
        }

        public void Mkdir(string path)
        {
            var pathArray = path.Split('/');

            var head = _fileSystemItem;

            foreach (var pathItem in pathArray)
            {
                if (!head.Items.ContainsKey(pathItem))
                {
                    head.Items.Add(pathItem, new FileSystemItem());
                }

                head = head.Items[pathItem];
            }
        }

        public void AddContentToFile(string filePath, string content)
        {
            var file = GetItem(filePath);
            file.Content += content;
            file.IsFile = true;
        }

        public string ReadContentFromFile(string filePath)
        {
            var file = GetItem(filePath);
            return file.Content;
        }

        private FileSystemItem GetItem(string path)
        {
            var pathArray = path.Split('/');

            var head = _fileSystemItem;

            foreach (var pathItem in pathArray)
            {
                if (!head.Items.ContainsKey(pathItem))
                {
                    head.Items.Add(pathItem, new FileSystemItem());
                }

                head = head.Items[pathItem];
            }

            return head;
        }
    }
}