using System;
using Dogged.Native;

namespace Dogged
{
    /// <summary>
    /// An object (blob, commit, tree, etc) in a Git repository.
    /// </summary>
    public abstract class GitObject : NativeDisposable
    {
        private unsafe git_object* nativeObject;
        private ObjectId id;

        internal unsafe GitObject(git_object* nativeObject, ObjectId id = null)
        {
            Ensure.NativePointerNotNull(nativeObject);

            this.nativeObject = nativeObject;
            this.id = id;
        }

        /// <summary>
        /// Returns the type of the object.
        /// </summary>
        public abstract ObjectType Type { get; }

        /// <summary>
        /// Returns the object id.
        /// </summary>
        public unsafe ObjectId Id
        {
            get
            {
                Ensure.NotDisposed(this);

                if (id == null)
                {
                    git_oid* oid = libgit2.git_object_id(nativeObject);
                    Ensure.NativePointerNotNull(oid);

                    id = ObjectId.FromNative(*oid);
                }

                return id;
            }
        }

        internal unsafe git_object* NativeObject
        {
            get
            {
                return nativeObject;
            }
        }

        internal unsafe override bool IsDisposed
        {
            get
            {
                return (nativeObject == null);
            }
        }

        internal unsafe override void Dispose(bool disposing)
        {
            if (nativeObject != null)
            {
                libgit2.git_object_free(nativeObject);
                nativeObject = null;
            }
        }
    }
}
