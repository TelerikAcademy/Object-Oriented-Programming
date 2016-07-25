using Dealership.Common;
using Dealership.Contracts;
using System.Text;

namespace Dealership.Models
{
    public class Comment : IComment
    {
        private const string CommentHeader = "    ----------";
        private const string ContentProperty = "Content";
        private const string CommentIndentation = "    ";
        private const string AuthorHeader = "      User: ";

        private readonly string content;

        public Comment(string content)
        {
            this.content = content;

            this.ValidateFields();
        }

        public string Content
        {
            get
            {
                return this.content;
            }
        }

        public string Author { get; set; }

        public override string ToString()
        {
            var builder = new StringBuilder();

            builder.AppendLine(string.Format("{0}", CommentHeader));
            builder.AppendLine(CommentIndentation + this.Content);
            builder.AppendLine(AuthorHeader + this.Author);
            builder.Append(string.Format("{0}", CommentHeader));

            return builder.ToString();
        }

        private void ValidateFields()
        {
            Validator.ValidateNull(this.content, string.Format(Constants.PropertyCannotBeNull, ContentProperty));
            Validator.ValidateIntRange(this.content.Length, Constants.MinCommentLength, Constants.MaxCommentLength, string.Format(Constants.StringMustBeBetweenMinAndMax, ContentProperty, Constants.MinCommentLength, Constants.MaxCommentLength));
        }
    }
}
