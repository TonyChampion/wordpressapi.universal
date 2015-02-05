using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordPressAPI.Models;
using XmlRpcPortable;
using XmlRpcPortable.Converter;
using XmlRpcPortable.Models;

namespace WordPressAPI
{
    public class WordPressClient
    {
        private Uri _uri;
        private string _userName;
        private string _password;
        private int _blogId;

        private XmlRpcClient _client;

        public WordPressClient(string baseUri, string userName, string pwd, int blogId)
        {
            _userName = userName;
            _password = pwd;
            _blogId = blogId;

            if (!baseUri.EndsWith("/"))
            {
                baseUri += "/";
            }

            baseUri += "xmlrpc.php";

            _uri = new Uri(baseUri);
            _client = new XmlRpcClient(_uri);
        }


        #region Posts

        #region GetPosts
        public async Task<IEnumerable<WordPressPost>> GetPostsAsync(WordPressPostFilter filter = null)
        {
            return await GetPostsAsync(_blogId, filter);
        }

        public async Task<IEnumerable<WordPressPost>> GetPostsAsync(int blogId, WordPressPostFilter filter = null)
        {
            return await GetPostsAsync(blogId, _userName, _password, filter);
        }

        public async Task<IEnumerable<WordPressPost>> GetPostsAsync(int blogId, string userName, string password, WordPressPostFilter filter = null)
        {
            var parms = new List<XmlRpcValue>();

            parms.Add(new XmlRpcInt(blogId));
            parms.Add(new XmlRpcString(userName));
            parms.Add(new XmlRpcString(password));

            if (filter != null)
            {
                parms.Add(XmlRpcConverter.MapFrom(filter));
            }
            try
            {
                var results = await _client.CallRpc("wp.getPosts", parms);

                if (results != null)
                {
                    if (results.Value is XmlRpcArray)
                    {
                        return (IEnumerable<WordPressPost>) XmlRpcConverter.MapArrayTo(results.Value as XmlRpcArray, typeof(WordPressPost));
                    }
                } 
            }
            catch (XmlRpcException ex)
            {

            }
            return null;

        }
        #endregion

        #region GetPosts
        public async Task<WordPressPost> GetPostAsync(int postId)
        {
            return await GetPostAsync(postId, _blogId);
        }

        public async Task<WordPressPost> GetPostAsync(int postId, int blogId)
        {
            return await GetPostAsync(postId, blogId, _userName, _password);
        }

        public async Task<WordPressPost> GetPostAsync(int postId, int blogId, string userName, string password)
        {
            var parms = new List<XmlRpcValue>();

            parms.Add(new XmlRpcInt(blogId));
            parms.Add(new XmlRpcString(userName));
            parms.Add(new XmlRpcString(password));
            parms.Add(new XmlRpcString(postId.ToString()));

            try
            {
                var results = await _client.CallRpc("wp.getPost", parms);

                if (results != null)
                {
                    if (results.Value is XmlRpcStruct)
                    {
                        return (WordPressPost)XmlRpcConverter.MapTo<WordPressPost>(results.Value);
                    }
                }
            }
            catch (XmlRpcException ex)
            {

            }
            return null;

        }
        #endregion

        #endregion

        #region Comments
        #region GetComments
        public async Task<IEnumerable<WordPressComment>> GetCommentsAsync(int postId)
        {
            return await GetCommentsAsync(postId, _blogId);
        }

        public async Task<IEnumerable<WordPressComment>> GetCommentsAsync(int postId, int blogId)
        {
            return await GetCommentsAsync(postId, blogId, _userName, _password);
        }

        public async Task<IEnumerable<WordPressComment>> GetCommentsAsync(int postId, int blogId, string userName, string password)
        {
            var parms = new List<XmlRpcValue>();

            parms.Add(new XmlRpcInt(blogId));
            parms.Add(new XmlRpcString(userName));
            parms.Add(new XmlRpcString(password));

            var filter = new XmlRpcStruct();
            filter.StructValue.Add("post_id", new XmlRpcInt(postId));
            parms.Add(filter);

            try
            {
                var results = await _client.CallRpc("wp.getComments", parms);

                if (results != null)
                {
                    if (results.Value is XmlRpcArray)
                    {
                        return (IEnumerable<WordPressComment>)XmlRpcConverter.MapArrayTo(results.Value as XmlRpcArray, typeof(WordPressComment));
//                        return (IEnumerable<WordPressComment>)XmlRpcConverter.MapTo<>(results.Value);
                    }
                }
            }
            catch (XmlRpcException ex)
            {

            }
            return null;

        }
        #endregion

        #region GetComment
        public async Task<WordPressComment> GetCommentAsync(int commentId)
        {
            return await GetCommentAsync(commentId, _blogId);
        }

        public async Task<WordPressComment> GetCommentAsync(int commentId, int blogId)
        {
            return await GetCommentAsync(commentId, blogId, _userName, _password);
        }

        public async Task<WordPressComment> GetCommentAsync(int commentId, int blogId, string userName, string password)
        {
            var parms = new List<XmlRpcValue>();

            parms.Add(new XmlRpcInt(blogId));
            parms.Add(new XmlRpcString(userName));
            parms.Add(new XmlRpcString(password));
            parms.Add(new XmlRpcInt(commentId));

            //var filter = new XmlRpcStruct();
            //filter.StructValue.Add("comment_id", new XmlRpcInt(commentId));
            //parms.Add(filter);

            try
            {
                var results = await _client.CallRpc("wp.getComment", parms);

                if (results != null)
                {
                    if (results.Value is XmlRpcStruct)
                    {
                        return (WordPressComment)XmlRpcConverter.MapTo<WordPressComment>(results.Value);
                    }
                }
            }
            catch (XmlRpcException ex)
            {

            }
            return null;

        }
        #endregion

        #endregion

        #region Taxonomies
        #region GetTaxonomies
        public async Task<IEnumerable<WordPressTaxonomy>> GetTaxonomiesAsync()
        {
            return await GetTaxonomiesAsync(_blogId);
        }

        public async Task<IEnumerable<WordPressTaxonomy>> GetTaxonomiesAsync(int blogId)
        {
            return await GetTaxonomiesAsync(blogId, _userName, _password);
        }

        public async Task<IEnumerable<WordPressTaxonomy>> GetTaxonomiesAsync(int blogId, string userName, string password)
        {
            var parms = new List<XmlRpcValue>();

            parms.Add(new XmlRpcInt(blogId));
            parms.Add(new XmlRpcString(userName));
            parms.Add(new XmlRpcString(password));

            try
            {
                var results = await _client.CallRpc("wp.getTaxonomies", parms);

                if (results != null)
                {
                    if (results.Value is XmlRpcArray)
                    {
                        return (IEnumerable<WordPressTaxonomy>)XmlRpcConverter.MapArrayTo(results.Value as XmlRpcArray, typeof(WordPressTaxonomy));
                        //                        return (IEnumerable<WordPressComment>)XmlRpcConverter.MapTo<>(results.Value);
                    }
                }
            }
            catch (XmlRpcException ex)
            {

            }
            return null;

        }
        #endregion

        #region GetTaxonomy
        public async Task<WordPressTaxonomy> GetTaxonomyAsync(string taxonomy)
        {
            return await GetTaxonomyAsync(taxonomy, _blogId);
        }

        public async Task<WordPressTaxonomy> GetTaxonomyAsync(string taxonomy, int blogId)
        {
            return await GetTaxonomyAsync(taxonomy, blogId, _userName, _password);
        }

        public async Task<WordPressTaxonomy> GetTaxonomyAsync(string taxonomy, int blogId, string userName, string password)
        {
            var parms = new List<XmlRpcValue>();

            parms.Add(new XmlRpcInt(blogId));
            parms.Add(new XmlRpcString(userName));
            parms.Add(new XmlRpcString(password));
            parms.Add(new XmlRpcString(taxonomy));

            try
            {
                var results = await _client.CallRpc("wp.getTaxonomy", parms);

                if (results != null)
                {
                    if (results.Value is XmlRpcStruct)
                    {
                        return (WordPressTaxonomy)XmlRpcConverter.MapTo<WordPressTaxonomy>(results.Value);
                    }
                }
            }
            catch (XmlRpcException ex)
            {

            }
            return null;

        }
        #endregion

        #endregion

        #region Terms

        #region GetTerms
        public async Task<IEnumerable<WordPressTerm>> GetTermsAsync(string taxonomy, WordPressTermFilter filter = null)
        {
            return await GetTermsAsync(taxonomy, _blogId, filter);
        }

        public async Task<IEnumerable<WordPressTerm>> GetTermsAsync(string taxonomy, int blogId, WordPressTermFilter filter = null)
        {
            return await GetTermsAsync(taxonomy, blogId, _userName, _password, filter);
        }

        public async Task<IEnumerable<WordPressTerm>> GetTermsAsync(string taxonomy, int blogId, string userName, string password, WordPressTermFilter filter = null)
        {
            var parms = new List<XmlRpcValue>();

            parms.Add(new XmlRpcInt(blogId));
            parms.Add(new XmlRpcString(userName));
            parms.Add(new XmlRpcString(password));
            parms.Add(new XmlRpcString(taxonomy));

            if (filter != null)
            {
                parms.Add(XmlRpcConverter.MapFrom(filter));
            }
            try
            {
                var results = await _client.CallRpc("wp.getTerms", parms);

                if (results != null)
                {
                    if (results.Value is XmlRpcArray)
                    {
                        return (IEnumerable<WordPressTerm>)XmlRpcConverter.MapArrayTo(results.Value as XmlRpcArray, typeof(WordPressTerm));
                    }
                }
            }
            catch (XmlRpcException ex)
            {

            }
            return null;

        }
        #endregion

        #region GetTerm
        public async Task<WordPressTerm> GetTermAsync(string taxonomy, int termId)
        {
            return await GetTermAsync(taxonomy, termId, _blogId);
        }

        public async Task<WordPressTerm> GetTermAsync(string taxonomy, int termId, int blogId)
        {
            return await GetTermAsync(taxonomy, termId, blogId, _userName, _password);
        }

        public async Task<WordPressTerm> GetTermAsync(string taxonomy, int termId, int blogId, string userName, string password)
        {
            var parms = new List<XmlRpcValue>();

            parms.Add(new XmlRpcInt(blogId));
            parms.Add(new XmlRpcString(userName));
            parms.Add(new XmlRpcString(password));
            parms.Add(new XmlRpcString(taxonomy));
            parms.Add(new XmlRpcInt(termId));

            try
            {
                var results = await _client.CallRpc("wp.getTerm", parms);

                if (results != null)
                {
                    if (results.Value is XmlRpcStruct)
                    {
                        return (WordPressTerm)XmlRpcConverter.MapTo<WordPressTerm>(results.Value);
                    }
                }
            }
            catch (XmlRpcException ex)
            {

            }
            return null;

        }
        #endregion

        #endregion

        #region Users

        #region GetUsersBlogs
        public async Task<IEnumerable<WordPressBlog>> GetUsersBlogsAsync()
        {
            return await GetUsersBlogsAsync(_userName, _password);
        }

        public async Task<IEnumerable<WordPressBlog>> GetUsersBlogsAsync(string userName, string password)
        {
            var parms = new List<XmlRpcValue>();

            parms.Add(new XmlRpcString(userName));
            parms.Add(new XmlRpcString(password));

            try
            {
                var results = await _client.CallRpc("wp.getUsersBlogs", parms);

                if (results != null)
                {
                    if (results.Value is XmlRpcArray)
                    {
                        return (IEnumerable<WordPressBlog>)XmlRpcConverter.MapArrayTo(results.Value as XmlRpcArray, typeof(WordPressBlog));
                    }
                }
            }
            catch (XmlRpcException ex)
            {

            }
            return null;

        }
        #endregion

        #region GetUser
        public async Task<WordPressUser> GetUserAsync(int userId)
        {
            return await GetUserAsync(userId, _blogId);
        }

        public async Task<WordPressUser> GetUserAsync(int userId, int blogId)
        {
            return await GetUserAsync(userId, blogId, _userName, _password);
        }

        public async Task<WordPressUser> GetUserAsync(int userId, int blogId, string userName, string password)
        {
            var parms = new List<XmlRpcValue>();

            parms.Add(new XmlRpcInt(blogId));
            parms.Add(new XmlRpcString(userName));
            parms.Add(new XmlRpcString(password));
            parms.Add(new XmlRpcInt(userId));

            try
            {
                var results = await _client.CallRpc("wp.getUser", parms);

                if (results != null)
                {
                    if (results.Value is XmlRpcStruct)
                    {
                        return (WordPressUser)XmlRpcConverter.MapTo<WordPressUser>(results.Value);
                    }
                }
            }
            catch (XmlRpcException ex)
            {

            }
            return null;

        }
        #endregion

        #region GetUsers
        public async Task<IEnumerable<WordPressUser>> GetUsersAsync(WordPressUserFilter filter = null)
        {
            return await GetUsersAsync(_blogId, filter);
        }

        public async Task<IEnumerable<WordPressUser>> GetUsersAsync(int blogId, WordPressUserFilter filter = null)
        {
            return await GetUsersAsync(blogId, _userName, _password, filter);
        }

        public async Task<IEnumerable<WordPressUser>> GetUsersAsync(int blogId, string userName, string password, WordPressUserFilter filter = null)
        {
            var parms = new List<XmlRpcValue>();

            parms.Add(new XmlRpcInt(blogId));
            parms.Add(new XmlRpcString(userName));
            parms.Add(new XmlRpcString(password));

            if (filter != null)
            {
                parms.Add(XmlRpcConverter.MapFrom(filter));
            }
            try
            {
                var results = await _client.CallRpc("wp.getUsers", parms);

                if (results != null)
                {
                    if (results.Value is XmlRpcArray)
                    {
                        return (IEnumerable<WordPressUser>)XmlRpcConverter.MapArrayTo(results.Value as XmlRpcArray, typeof(WordPressUser));
                    }
                }
            }
            catch (XmlRpcException ex)
            {

            }
            return null;

        }
        #endregion

        #region GetProfile
        public async Task<WordPressUser> GetProfileAsync()
        {
            return await GetProfileAsync(_blogId);
        }

        public async Task<WordPressUser> GetProfileAsync(int blogId)
        {
            return await GetProfileAsync(blogId, _userName, _password);
        }

        public async Task<WordPressUser> GetProfileAsync(int blogId, string userName, string password)
        {
            var parms = new List<XmlRpcValue>();

            parms.Add(new XmlRpcInt(blogId));
            parms.Add(new XmlRpcString(userName));
            parms.Add(new XmlRpcString(password));

            try
            {
                var results = await _client.CallRpc("wp.getProfile", parms);

                if (results != null)
                {
                    if (results.Value is XmlRpcStruct)
                    {
                        return (WordPressUser)XmlRpcConverter.MapTo<WordPressUser>(results.Value);
                    }
                }
            }
            catch (XmlRpcException ex)
            {

            }
            return null;

        }
        #endregion

        #region GetAuthors
        public async Task<IEnumerable<WordPressAuthor>> GetAuthorsAsync()
        {
            return await GetAuthorsAsync(_blogId);
        }

        public async Task<IEnumerable<WordPressAuthor>> GetAuthorsAsync(int blogId)
        {
            return await GetAuthorsAsync(blogId, _userName, _password);
        }

        public async Task<IEnumerable<WordPressAuthor>> GetAuthorsAsync(int blogId, string userName, string password)
        {
            var parms = new List<XmlRpcValue>();

            parms.Add(new XmlRpcInt(blogId));
            parms.Add(new XmlRpcString(userName));
            parms.Add(new XmlRpcString(password));


            try
            {
                var results = await _client.CallRpc("wp.getAuthors", parms);

                if (results != null)
                {
                    if (results.Value is XmlRpcArray)
                    {
                        return (IEnumerable<WordPressAuthor>)XmlRpcConverter.MapArrayTo(results.Value as XmlRpcArray, typeof(WordPressAuthor));
                    }
                }
            }
            catch (XmlRpcException ex)
            {

            }
            return null;

        }
        #endregion

        #endregion

        #region Options

        #region GetOptions
        public async Task<WordPressOptions> GetOptionsAsync()
        {
            return await GetOptionsAsync(_blogId);
        }

        public async Task<WordPressOptions> GetOptionsAsync(int blogId)
        {
            return await GetOptionsAsync(blogId, _userName, _password);
        }

        public async Task<WordPressOptions> GetOptionsAsync(int blogId, string userName, string password)
        {
            var parms = new List<XmlRpcValue>();

            parms.Add(new XmlRpcInt(blogId));
            parms.Add(new XmlRpcString(userName));
            parms.Add(new XmlRpcString(password));


            try
            {
                var results = await _client.CallRpc("wp.getOptions", parms);

                if (results != null)
                {
                    if (results.Value is XmlRpcStruct)
                    {
                        return (WordPressOptions)XmlRpcConverter.MapTo<WordPressOptions>(results.Value);
                    }
                }
            }
            catch (XmlRpcException ex)
            {

            }
            return null;

        }
        #endregion

        #endregion

    }
}
