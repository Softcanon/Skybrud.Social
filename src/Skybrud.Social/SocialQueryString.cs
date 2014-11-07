using System;
using System.Collections.Specialized;
using System.Globalization;

namespace Skybrud.Social {

    /// <summary>
    /// A wrapper class extending the functionality of <code>NameValueCollection</code>.
    /// </summary>
    public class SocialQueryString {

        #region Private fields

        private readonly NameValueCollection _nvc = new NameValueCollection();

        #endregion

        #region Properties

        /// <summary>
        /// Gets a reference to the internal <code>NameValueCollection</code>.
        /// </summary>
        public NameValueCollection NameValueCollection {
            get { return _nvc; }
        }

        /// <summary>
        /// Gets the number of key/value pairs contained in the internal <code>NameValueCollection</code> instance.
        /// </summary>
        public int Count {
            get { return _nvc.Count; }
        }

        /// <summary>
        /// Gets whether the internal <code>NameValueCollection</code> is empty.
        /// </summary>
        public bool IsEmpty {
            get { return _nvc.Count == 0; }
        }

        #endregion

        #region Constructors

        public SocialQueryString() {
            // Expose default constructor
        }

        public SocialQueryString(NameValueCollection nvc) {
            _nvc = nvc ?? new NameValueCollection();
        }

        #endregion

        #region Methods

        public void Set(string key, bool value) {
            _nvc.Set(key, value ? "true" : "false");
        }

        public void Set(string key, bool value, bool condition) {
            if (condition) _nvc.Set(key, value ? "true" : "false");
        }

        public void Set(string key, int value) {
            _nvc.Set(key, value.ToString(CultureInfo.InvariantCulture));
        }

        public void Set(string key, int value, bool condition) {
            if (condition) _nvc.Set(key, value.ToString(CultureInfo.InvariantCulture));
        }

        public void Set(string key, string value) {
            _nvc.Set(key, value);
        }

        public void Set(string key, string value, bool condition) {
            if (condition) _nvc.Set(key, value);
        }

        public override string ToString() {
            return SocialUtils.NameValueCollectionToQueryString(_nvc);
        }

        public void Set(string key, Func<string> func, bool condition) {
            if (!condition) return;
            _nvc.Set(key, func());
        }

        #endregion

    }

}
