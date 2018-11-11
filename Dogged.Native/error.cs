using System;
using System.Runtime.InteropServices;

namespace Dogged.Native
{
    /// <summary>
    /// The return codes from a libgit2 function; GIT_OK is used when the
    /// function call succeeded, otherwise a negative value is returned.
    /// Most functions return GIT_ERROR on fatal error, but may return a
    /// more detailed error code to allow callers to respond.
    /// </summary>
    public enum git_error_code
    {
        /// <summary>
        /// No error.
        /// </summary>
        GIT_OK = 0,

        /// <summary>
        /// An error occured; call <see cref="git_error_last"/> for more information.
        /// </summary>
        GIT_ERROR = -1,

        /// <summary>
        /// Requested object could not be found.
        /// </summary>
        GIT_ENOTFOUND = -3,

        /// <summary>
        /// Object exists preventing operation.
        /// </summary>
        GIT_EEXISTS = -4,

        /// <summary>
        /// More than one object matches.
        /// </summary>
        GIT_EAMBIGUOUS = -5,

        /// <summary>
        /// Output buffer too short to hold data.
        /// </summary>
        GIT_EBUFS = -6,

        /// <summary>
        /// GIT_EUSER is a special error that is never generated by libgit2
        ///  code.  You can return it from a callback (e.g to stop an iteration)
        /// to know that it was generated by the callback and not by libgit2.
        /// </summary>
        GIT_EUSER = -7,

        /// <summary>
        /// Operation not allowed on bare repository.
        /// </summary>
        GIT_EBAREREPO = -8,

        /// <summary>
        /// HEAD refers to branch with no commits.
        /// </summary>
        GIT_EUNBORNBRANCH = -9,

        /// <summary>
        /// Merge in progress prevented operation.
        /// </summary>
        GIT_EUNMERGED = -10,

        /// <summary>
        /// Reference was not fast-forwardable.
        /// </summary>
        GIT_ENONFASTFORWARD = -11,

        /// <summary>
        /// Name/ref spec was not in a valid format.
        /// </summary>
        GIT_EINVALIDSPEC = -12,

        /// <summary>
        /// Checkout conflicts prevented operation.
        /// </summary>
        GIT_ECONFLICT = -13,

        /// <summary>
        /// Lock file prevented operation.
        /// </summary>
        GIT_ELOCKED = -14,

        /// <summary>
        /// Reference value does not match expected.
        /// </summary>
        GIT_EMODIFIED = -15,

        /// <summary>
        /// Authentication error.
        /// </summary>
        GIT_EAUTH = -16,

        /// <summary>
        /// Server certificate is invalid.
        /// </summary>
        GIT_ECERTIFICATE = -17,

        /// <summary>
        /// Patch/merge has already been applied.
        /// </summary>
        GIT_EAPPLIED = -18,

        /// <summary>
        /// The requested peel operation is not possible.
        /// </summary>
        GIT_EPEEL = -19,

        /// <summary>
        /// Unexpected EOF.
        /// </summary>
        GIT_EEOF = -20,

        /// <summary>
        /// Invalid operation or input.
        /// </summary>
        GIT_EINVALID = -21,

        /// <summary>
        /// Uncommitted changes in index prevented operation.
        /// </summary>
        GIT_EUNCOMMITTED = -22,

        /// <summary>
        /// The operation is not valid for a directory.
        /// </summary>
        GIT_EDIRECTORY = -23,

        /// <summary>
        /// A merge conflict exists and cannot continue.
        /// </summary>
        GIT_EMERGECONFLICT = -24,

        /// <summary>
        /// A user-configured callback refused to act.
        /// </summary>
        GIT_PASSTHROUGH = -30,

        /// <summary>
        /// Signals end of iteration with iterator.
        /// </summary>
        GIT_ITEROVER = -31,

        /// <summary>
        /// Internal only.
        /// </summary>
        GIT_RETRY = -32,

        /// <summary>
        /// Hashsum mismatch in object.
        /// </summary>
        GIT_EMISMATCH = -33,

        /// <summary>
        /// Unsaved changes in the index would be overwritten.
        /// </summary>
        GIT_EINDEXDIRTY = -34,

        /// <summary>
        /// Patch application failed.
        /// </summary>
        GIT_EAPPLYFAIL = -35,
    }

    /// <summary>
    /// Error classes store the area of the code where the error occurred.
    /// </summary>
    public enum git_error_t
    {
        GITERR_NONE = 0,
        GITERR_NOMEMORY,
        GITERR_OS,
        GITERR_INVALID,
        GITERR_REFERENCE,
        GITERR_ZLIB,
        GITERR_REPOSITORY,
        GITERR_CONFIG,
        GITERR_REGEX,
        GITERR_ODB,
        GITERR_INDEX,
        GITERR_OBJECT,
        GITERR_NET,
        GITERR_TAG,
        GITERR_TREE,
        GITERR_INDEXER,
        GITERR_SSL,
        GITERR_SUBMODULE,
        GITERR_THREAD,
        GITERR_STASH,
        GITERR_CHECKOUT,
        GITERR_FETCHHEAD,
        GITERR_MERGE,
        GITERR_SSH,
        GITERR_FILTER,
        GITERR_REVERT,
        GITERR_CALLBACK,
        GITERR_CHERRYPICK,
        GITERR_DESCRIBE,
        GITERR_REBASE,
        GITERR_FILESYSTEM,
        GITERR_PATCH,
        GITERR_WORKTREE,
        GITERR_SHA1
    }

    /// <summary>
    /// Structure to store details of the last error that occurred.  This
    /// is kept on a per-thread basis.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct git_error
    {
        /// <summary>The error message.</summary>
        public byte* message;

        /// <summary>The error category.</summary>
        public git_error_t category;
    }
}
