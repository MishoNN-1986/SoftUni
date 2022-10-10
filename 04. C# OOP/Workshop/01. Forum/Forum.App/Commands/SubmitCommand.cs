﻿using _01._Forum.Forum.App.Contracts.Models;
using _01._Forum.Forum.App.Contracts.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Forum.Forum.App.Commands
{
    class SubmitCommand : ICommand
    {
        private ISession session;
        private IPostService postService;

        public SubmitCommand(ISession session, IPostService postService)
        {
            this.session = session;
            this.postService = postService;
        }

        public IMenu Execute(params string[] args)
        {
            string replyText = args[0];
            int postId = int.Parse(args[1]);
            int authorId = this.session.UserId;

            this.postService.AddReplyToPost(postId, replyText, authorId);
            return this.session.Back();
        }
    }
}
