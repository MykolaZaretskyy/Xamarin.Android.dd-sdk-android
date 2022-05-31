using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Datadog.Android.Core.Internal.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.core.internal.utils']/class[@name='ByteArrayExtKt']"
	[global::Android.Runtime.Register ("com/datadog/android/core/internal/utils/ByteArrayExtKt", DoNotGenerateAcw=true)]
	public sealed partial class ByteArrayExtKt : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/core/internal/utils/ByteArrayExtKt", typeof (ByteArrayExtKt));

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

		internal ByteArrayExtKt (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.core.internal.utils']/class[@name='ByteArrayExtKt']/method[@name='indexOf' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='byte'] and parameter[3][@type='int']]"
		[Register ("indexOf", "([BBI)I", "")]
		public static unsafe int IndexOf (byte[] obj, sbyte b, int startIndex)
		{
			const string __id = "indexOf.([BBI)I";
			IntPtr native_obj = JNIEnv.NewArray (obj);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_obj);
				__args [1] = new JniArgumentValue (b);
				__args [2] = new JniArgumentValue (startIndex);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (obj != null) {
					JNIEnv.CopyArray (native_obj, obj);
					JNIEnv.DeleteLocalRef (native_obj);
				}
				global::System.GC.KeepAlive (obj);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.core.internal.utils']/class[@name='ByteArrayExtKt']/method[@name='split' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte']]"
		[Register ("split", "([BB)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<byte[]> Split (byte[] obj, sbyte delimiter)
		{
			const string __id = "split.([BB)Ljava/util/List;";
			IntPtr native_obj = JNIEnv.NewArray (obj);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_obj);
				__args [1] = new JniArgumentValue (delimiter);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList<byte[]>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (obj != null) {
					JNIEnv.CopyArray (native_obj, obj);
					JNIEnv.DeleteLocalRef (native_obj);
				}
				global::System.GC.KeepAlive (obj);
			}
		}

	}
}
