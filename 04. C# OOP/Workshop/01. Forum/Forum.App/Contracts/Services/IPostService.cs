using _01._Forum.Forum.App.Contracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Forum.Forum.App.Contracts.Services
{
    public interface IPostService
    {
        IEnumerable<ICategoryInfoViewModel> GetAllCategories();

        IEnumerable<IPostInfoViewModel> GetCategoryPostsInfo(int categoryId);

        string GetCategoryName(int categoryId);

        IPostViewModel GetPostViewModel(int postId);
        int AddPost(int userId, string postTitle, string postCategory, string postContent);
        void AddReplyToPost(int postId, string replyContents, int userId);
    }
}
