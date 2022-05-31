using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Datadog.Android.Core.Internal.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.core.internal.utils']/class[@name='RuntimeUtilsKt']"
	[global::Android.Runtime.Register ("com/datadog/android/core/internal/utils/RuntimeUtilsKt", DoNotGenerateAcw=true)]
	public sealed partial class RuntimeUtilsKt : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.core.internal.utils']/class[@name='RuntimeUtilsKt']/field[@name='DEV_LOG_PREFIX']"
		[Register ("DEV_LOG_PREFIX")]
		public const string DevLogPrefix = (string) "Datadog";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.core.internal.utils']/class[@name='RuntimeUtilsKt']/field[@name='SDK_LOG_PREFIX']"
		[Register ("SDK_LOG_PREFIX")]
		public const string SdkLogPrefix = (string) "DD_LOG";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.core.internal.utils']/class[@name='RuntimeUtilsKt']/field[@name='WARN_DEPRECATED']"
		[Register ("WARN_DEPRECATED")]
		public const string WarnDeprecated = (string) "%s has been deprecated since version %s, and will be removed in version %s.";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.core.internal.utils']/class[@name='RuntimeUtilsKt']/field[@name='WARN_DEPRECATED_WITH_ALT']"
		[Register ("WARN_DEPRECATED_WITH_ALT")]
		public const string WarnDeprecatedWithAlt = (string) "%s has been deprecated since version %s, and will be removed in version %s. Please use %s instead";

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/core/internal/utils/RuntimeUtilsKt", typeof (RuntimeUtilsKt));

		internal static IntPtr class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		internal RuntimeUtilsKt (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

	}
}
