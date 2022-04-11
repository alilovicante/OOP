using System;
using System.Collections.Generic;
using System.Text;

namespace lv6
{
    class Post
    {
        string user;
        string message;
        List<string> hashtags;
        DateTime postTime;

        public Post(string user,string message, List<string> hashtags)
        {
            this.user = user;
            this.message = message;
            this.hashtags = hashtags;
            postTime = DateTime.Now;
        }
        public Post(Post other)
        {
            user = other.user;
            message = other.message;
            postTime = other.postTime;
            hashtags = new List<string>();
            hashtags.AddRange(other.hashtags);
        }
        public void Tag(string tag)
        {
            hashtags.Add(tag);
        }
        public void Untag()
        {
            this.hashtags = new List<string>();
        }
        public override string ToString()
        {
            string output = $"{user}: {message}";
            foreach(string tag in hashtags)
            {
                output += $" {tag}";
            }
            output += $" @{postTime}";
            return output;
        }
        public static string GetAsString<K, V>(Dictionary<K, V> dictionary)
        {
            string output = string.Empty;
            foreach (var key in dictionary.Keys)
            {
                output += $"Value under [{key}]: {dictionary[key].ToString()}{Environment.NewLine}";
            }
            return output;
        }
    }
}
