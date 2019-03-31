using Forum.App.UserInterface.ViewModels;
using Forum.Data;
using Forum.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Forum.App.Services
{
    internal static class PostService
    {
        public static Category GetCategory(int id)
        {
            ForumData forumData = new ForumData();
            var category = forumData.Categories.SingleOrDefault(c => c.Id == id);
            return category;


        }

        public static IList<ReplyViewModel> GetPostReplies(int postId)
        {
            var forumData = new ForumData();
            var post = forumData.Posts.Single(p => p.Id == postId);

            var replies = new List<ReplyViewModel>();
            foreach (var replyId in post.ReplyIds)
            {
                var reply = forumData.Replies.Single(r => r.Id == replyId);
                replies.Add(new ReplyViewModel(reply));
            }
            return replies;
        }

        public static string[] GetAllCategoryNames()
        {
            ForumData forumdata = new ForumData();
            var allCategories = forumdata.Categories.Select(c => c.Name).ToArray();
            return allCategories;
        }

        public static IEnumerable<Post> GetPostsByCategory(int categoryId)
        {
            ForumData forumdata = new ForumData();
            var category = forumdata.Categories.Single(c => c.Id == categoryId);
            var posts = forumdata
                .Posts
                .Where(p => category.PostsIds.Contains(p.Id)).ToList();
            return posts;
        }

        public static PostViewModel GetPostViewModel(int postId)
        {
            ForumData forumdata = new ForumData();
            var post = forumdata.Posts.Single(p => p.Id == postId);

            return new PostViewModel(post);
        }

        private static Category EnsureCategory(PostViewModel postView, ForumData forumData)
        {
            var categoryName = postView.Category;
            Category category = forumData
                .Categories
                .SingleOrDefault(c => c.Name == categoryName);
            if (category == null)
            {
                int id = forumData.Categories.LastOrDefault()?.Id + 1 ?? 1;
                category = new Category(id, categoryName, new List<int>());
                forumData.Categories.Add(category);
                forumData.SaveChanges();
            }
            return category;
        }

        public static bool TrySavePost(PostViewModel postViewModel)
        {
            var isTitleValid = !string.IsNullOrWhiteSpace(postViewModel.Title);
            var isContentValid = postViewModel.Content.Any();
            var isCategoryValid = !string.IsNullOrWhiteSpace(postViewModel.Category);

            if (!isTitleValid || !isContentValid || !isCategoryValid)
            {
                return false;
            }

            var forumData = new ForumData();
            var category = EnsureCategory(postViewModel, forumData);

            var postId = forumData.Posts.LastOrDefault()?.Id + 1 ?? 1;
            var author = UserService.GetUser(postViewModel.Author, forumData);
            var content = string.Join("", postViewModel.Content);
            var post = new Post(postId, postViewModel.Title, content, category.Id, author.Id, new List<int>());
            forumData.Posts.Add(post);
            category.PostsIds.Add(postId);
            author.PostsIds.Add(postId);
            forumData.SaveChanges();
            postViewModel.PostId = postId;
            return true;
        }

        public static bool TrySaveReply(ReplyViewModel replyViewModel, int postId)
        {
            if (! replyViewModel.Content.Any())
            {
                return false;
            }
            var forumData = new ForumData();
            var author = UserService.GetUser(replyViewModel.Author, forumData);
            var post = forumData.Posts.Single(p => p.Id == postId);
            var replyId = forumData.Replies.LastOrDefault()?.Id + 1 ?? 1;
            var content = string.Join("", replyViewModel.Content);
            var reply = new Reply(replyId, content, author.Id, postId);
            forumData.Replies.Add(reply);
            post.ReplyIds.Add(replyId);
            forumData.SaveChanges();
            return true;
        }
    }
}
