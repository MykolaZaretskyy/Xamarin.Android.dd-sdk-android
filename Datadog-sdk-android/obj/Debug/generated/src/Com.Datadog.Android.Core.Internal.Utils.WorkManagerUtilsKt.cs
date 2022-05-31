using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Datadog.Android.Core.Internal.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.core.internal.utils']/class[@name='WorkManagerUtilsKt']"
	[global::Android.Runtime.Register ("com/datadog/android/core/internal/utils/WorkManagerUtilsKt", DoNotGenerateAcw=true)]
	public sealed partial class WorkManagerUtilsKt : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.core.internal.utils']/class[@name='WorkManagerUtilsKt']/field[@name='CANCEL_ERROR_MESSAGE']"
		[Register ("CANCEL_ERROR_MESSAGE")]
		public const string CancelErrorMessage = (string) "Error cancelling the UploadWorker";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.core.internal.utils']/class[@name='WorkManagerUtilsKt']/field[@name='DELAY_MS']"
		[Register ("DELAY_MS")]
		public const long DelayMs = (long) 5000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.core.internal.utils']/class[@name='WorkManagerUtilsKt']/field[@name='SETUP_ERROR_MESSAGE']"
		[Register ("SETUP_ERROR_MESSAGE")]
		public const string SetupErrorMessage = (string) "Error while trying to setup the upload worker.";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.core.internal.utils']/class[@name='WorkManagerUtilsKt']/field[@name='TAG_DATADOG_UPLOAD']"
		[Register ("TAG_DATADOG_UPLOAD")]
		public const string TagDatadogUpload = (string) "DatadogBackgroundUpload";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.core.internal.utils']/class[@name='WorkManagerUtilsKt']/field[@name='UPLOAD_WORKER_NAME']"
		[Register ("UPLOAD_WORKER_NAME")]
		public const string UploadWorkerName = (string) "DatadogUploadWorker";

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/core/internal/utils/WorkManagerUtilsKt", typeof (WorkManagerUtilsKt));

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

		internal WorkManagerUtilsKt (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

	}
}
