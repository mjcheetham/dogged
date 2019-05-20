using Dogged.Native;

namespace Dogged
{
    public class GitBuffer : NativeDisposable
    {
        private unsafe git_buf* nativeBuf;

        private unsafe GitBuffer(git_buf* nativeBuf)
        {
            Ensure.ArgumentNotNull(nativeBuf, nameof(nativeBuf));
            this.nativeBuf = nativeBuf;
        }

        internal unsafe static GitBuffer FromNative(git_buf* nativeBuf)
        {
            return new GitBuffer(nativeBuf);
        }

        internal unsafe override bool IsDisposed
        {
            get
            {
                return (nativeBuf == null);
            }
        }

        internal unsafe override void Dispose(bool disposing)
        {
            if (nativeBuf != null)
            {
                libgit2.git_buf_dispose(nativeBuf);
                nativeBuf = null;
            }
        }
    }
}
