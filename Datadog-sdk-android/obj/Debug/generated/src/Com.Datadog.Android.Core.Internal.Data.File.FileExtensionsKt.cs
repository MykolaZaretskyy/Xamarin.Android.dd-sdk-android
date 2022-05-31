using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Datadog.Android.Core.Internal.Data.File {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.core.internal.data.file']/class[@name='FileExtensionsKt']"
	[global::Android.Runtime.Register ("com/datadog/android/core/internal/data/file/FileExtensionsKt", DoNotGenerateAcw=true)]
	public sealed partial class FileExtensionsKt : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/core/internal/data/file/FileExtensionsKt", typeof (FileExtensionsKt));

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

		internal FileExtensionsKt (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.core.internal.data.file']/class[@name='FileExtensionsKt']/method[@name='readBytes' and count(parameter)=3 and parameter[1][@type='java.io.File'] and parameter[2][@type='java.lang.CharSequence'] and parameter[3][@type='java.lang.CharSequence']]"
		[Register ("readBytes", "(Ljava/io/File;Ljava/lang/CharSequence;Ljava/lang/CharSequence;)[B", "")]
		public static unsafe byte[] ReadBytes (global::Java.IO.File obj, global::Java.Lang.ICharSequence withPrefix, global::Java.Lang.ICharSequence withSuffix)
		{
			const string __id = "readBytes.(Ljava/io/File;Ljava/lang/CharSequence;Ljava/lang/CharSequence;)[B";
			IntPtr native_withPrefix = CharSequence.ToLocalJniHandle (withPrefix);
			IntPtr native_withSuffix = CharSequence.ToLocalJniHandle (withSuffix);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				__args [1] = new JniArgumentValue (native_withPrefix);
				__args [2] = new JniArgumentValue (native_withSuffix);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				JNIEnv.DeleteLocalRef (native_withPrefix);
				JNIEnv.DeleteLocalRef (native_withSuffix);
				global::System.GC.KeepAlive (obj);
				global::System.GC.KeepAlive (withPrefix);
				global::System.GC.KeepAlive (withSuffix);
			}
		}

		public static byte[] ReadBytes (global::Java.IO.File obj, string withPrefix, string withSuffix)
		{
			var jls_withPrefix = withPrefix == null ? null : new global::Java.Lang.String (withPrefix);
			var jls_withSuffix = withSuffix == null ? null : new global::Java.Lang.String (withSuffix);
			byte[] __result = ReadBytes (obj, jls_withPrefix, jls_withSuffix);
			var __rsval = __result;
			jls_withPrefix?.Dispose ();
			jls_withSuffix?.Dispose ();
			return __rsval;
		}

	}
}
