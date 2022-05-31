using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Datadog.Android.Rum.Resource {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.resource']/class[@name='RumResourceInputStream']"
	[global::Android.Runtime.Register ("com/datadog/android/rum/resource/RumResourceInputStream", DoNotGenerateAcw=true)]
	public sealed partial class RumResourceInputStream : global::Java.IO.InputStream {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.resource']/class[@name='RumResourceInputStream']/field[@name='ERROR_CLOSE']"
		[Register ("ERROR_CLOSE")]
		public const string ErrorClose = (string) "Error closing input stream";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.resource']/class[@name='RumResourceInputStream']/field[@name='ERROR_MARK']"
		[Register ("ERROR_MARK")]
		public const string ErrorMark = (string) "Error marking input stream";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.resource']/class[@name='RumResourceInputStream']/field[@name='ERROR_READ']"
		[Register ("ERROR_READ")]
		public const string ErrorRead = (string) "Error reading from input stream";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.resource']/class[@name='RumResourceInputStream']/field[@name='ERROR_RESET']"
		[Register ("ERROR_RESET")]
		public const string ErrorReset = (string) "Error resetting input stream";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.resource']/class[@name='RumResourceInputStream']/field[@name='ERROR_SKIP']"
		[Register ("ERROR_SKIP")]
		public const string ErrorSkip = (string) "Error skipping bytes from input stream";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.resource']/class[@name='RumResourceInputStream']/field[@name='METHOD']"
		[Register ("METHOD")]
		public const string Method = (string) "GET";

		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.resource']/class[@name='RumResourceInputStream.Companion']"
		[global::Android.Runtime.Register ("com/datadog/android/rum/resource/RumResourceInputStream$Companion", DoNotGenerateAcw=true)]
		public sealed partial class Companion : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/resource/RumResourceInputStream$Companion", typeof (Companion));

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

			internal Companion (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.resource']/class[@name='RumResourceInputStream.Companion']/constructor[@name='RumResourceInputStream.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
			[Register (".ctor", "(Lkotlin/jvm/internal/DefaultConstructorMarker;)V", "")]
			public unsafe Companion (global::Kotlin.Jvm.Internal.DefaultConstructorMarker _constructor_marker) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Lkotlin/jvm/internal/DefaultConstructorMarker;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((_constructor_marker == null) ? IntPtr.Zero : ((global::Java.Lang.Object) _constructor_marker).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (_constructor_marker);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/resource/RumResourceInputStream", typeof (RumResourceInputStream));

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

		internal RumResourceInputStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.resource']/class[@name='RumResourceInputStream']/constructor[@name='RumResourceInputStream' and count(parameter)=2 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/io/InputStream;Ljava/lang/String;)V", "")]
		public unsafe RumResourceInputStream (global::System.IO.Stream @delegate, string url) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/io/InputStream;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native__delegate = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (@delegate);
			IntPtr native_url = JNIEnv.NewString (url);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native__delegate);
				__args [1] = new JniArgumentValue (native_url);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native__delegate);
				JNIEnv.DeleteLocalRef (native_url);
				global::System.GC.KeepAlive (@delegate);
			}
		}

		public unsafe global::System.IO.Stream Delegate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.resource']/class[@name='RumResourceInputStream']/method[@name='getDelegate' and count(parameter)=0]"
			[Register ("getDelegate", "()Ljava/io/InputStream;", "")]
			get {
				const string __id = "getDelegate.()Ljava/io/InputStream;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.InputStreamInvoker.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string Url {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.resource']/class[@name='RumResourceInputStream']/method[@name='getUrl' and count(parameter)=0]"
			[Register ("getUrl", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getUrl.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.resource']/class[@name='RumResourceInputStream']/method[@name='read' and count(parameter)=0]"
		[Register ("read", "()I", "")]
		public override unsafe int Read ()
		{
			const string __id = "read.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
