using Twitterizer;

namespace Memes_Viewer {
    class Twitter {
        private OAuthTokens tokens;

        public Twitter(string[] token) {
            tokens = new OAuthTokens();
            tokens.ConsumerKey = token[0];
            tokens.ConsumerSecret = token[1];
            tokens.AccessToken = token[2];
            tokens.AccessTokenSecret = token[3];
        }

        public bool post(string text) {
            text = Utils.HtmlDecode(text);
            return TwitterStatus.Update(tokens, text).Result == RequestResult.Success;
        }
    }
}
