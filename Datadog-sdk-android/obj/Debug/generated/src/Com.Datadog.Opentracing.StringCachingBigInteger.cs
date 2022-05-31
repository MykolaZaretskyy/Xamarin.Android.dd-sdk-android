using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Datadog.Opentracing {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.opentracing']/class[@name='StringCachingBigInteger']"
	[global::Android.Runtime.Register ("com/datadog/opentracing/StringCachingBigInteger", DoNotGenerateAcw=true)]
	public partial class StringCachingBigInteger : global::Java.Math.BigInteger {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/opentracing/StringCachingBigInteger", typeof (StringCachingBigInteger));

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

		protected StringCachingBigInteger (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.opentracing']/class[@name='StringCachingBigInteger']/constructor[@name='StringCachingBigInteger' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register (".ctor", "([B)V", "")]
		public unsafe StringCachingBigInteger (byte[] val) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([B)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_val = JNIEnv.NewArray (val);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_val);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (val != null) {
					JNIEnv.CopyArray (native_val, val);
					JNIEnv.DeleteLocalRef (native_val);
				}
				global::System.GC.KeepAlive (val);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.opentracing']/class[@name='StringCachingBigInteger']/constructor[@name='StringCachingBigInteger' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
		[Register (".ctor", "(I[B)V", "")]
		public unsafe StringCachingBigInteger (int signum, byte[] magnitude) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(I[B)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_magnitude = JNIEnv.NewArray (magnitude);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (signum);
				__args [1] = new JniArgumentValue (native_magnitude);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (magnitude != null) {
					JNIEnv.CopyArray (native_magnitude, magnitude);
					JNIEnv.DeleteLocalRef (native_magnitude);
				}
				global::System.GC.KeepAlive (magnitude);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.opentracing']/class[@name='StringCachingBigInteger']/constructor[@name='StringCachingBigInteger' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='java.util.Random']]"
		[Register (".ctor", "(IILjava/util/Random;)V", "")]
		public unsafe StringCachingBigInteger (int bitLength, int certainty, global::Java.Util.Random rnd) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(IILjava/util/Random;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (bitLength);
				__args [1] = new JniArgumentValue (certainty);
				__args [2] = new JniArgumentValue ((rnd == null) ? IntPtr.Zero : ((global::Java.Lang.Object) rnd).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (rnd);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.opentracing']/class[@name='StringCachingBigInteger']/constructor[@name='StringCachingBigInteger' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.util.Random']]"
		[Register (".ctor", "(ILjava/util/Random;)V", "")]
		public unsafe StringCachingBigInteger (int numBits, global::Java.Util.Random rnd) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(ILjava/util/Random;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (numBits);
				__args [1] = new JniArgumentValue ((rnd == null) ? IntPtr.Zero : ((global::Java.Lang.Object) rnd).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (rnd);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.opentracing']/class[@name='StringCachingBigInteger']/constructor[@name='StringCachingBigInteger' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe StringCachingBigInteger (string val) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_val = JNIEnv.NewString (val);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_val);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_val);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.opentracing']/class[@name='StringCachingBigInteger']/constructor[@name='StringCachingBigInteger' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Ljava/lang/String;I)V", "")]
		public unsafe StringCachingBigInteger (string val, int radix) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_val = JNIEnv.NewString (val);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_val);
				__args [1] = new JniArgumentValue (radix);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_val);
			}
		}

	}
}
