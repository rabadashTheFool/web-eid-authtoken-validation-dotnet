/*
 * Copyright © 2020-2024 Estonian Information System Authority
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 */
namespace WebEid.Security.AuthToken
{
    /// <summary>
    /// The Web eID authentication token
    /// </summary>
    public class WebEidAuthToken
    {
        /// <summary>
        /// The signature algorithm used to produce the signature.
        /// The allowed values are the algorithms specified in JWA RFC sections 3.3, 3.4 and 3.5
        /// </summary>
        public string Algorithm { get; set; }
        /// <summary>
        /// The type identifier and version of the token format separated by a colon character ':', web-eid:1.0 for example.
        /// The version number consists of the major and minor number separated by a dot.
        /// </summary>
        public string Format { get; set; }
        /// <summary>
        /// The base64-encoded signature of the token.
        /// </summary>
        public string Signature { get; set; }
        /// <summary>
        /// The base64-encoded DER-encoded authentication certificate of the eID user.
        /// </summary>
        public string UnverifiedCertificate { get; set; }
    }
}
