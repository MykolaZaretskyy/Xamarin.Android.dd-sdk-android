using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Datadog.Trace.Common.Writer {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.datadog.trace.common.writer']/interface[@name='Writer']"
	[Register ("com/datadog/trace/common/writer/Writer", "", "Com.Datadog.Trace.Common.Writer.IWriterInvoker")]
	public partial interface IWriter : global::Java.IO.ICloseable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.common.writer']/interface[@name='Writer']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler:Com.Datadog.Trace.Common.Writer.IWriterInvoker, Datadog_sdk_android")]
		void Close ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.common.writer']/interface[@name='Writer']/method[@name='incrementTraceCount' and count(parameter)=0]"
		[Register ("incrementTraceCount", "()V", "GetIncrementTraceCountHandler:Com.Datadog.Trace.Common.Writer.IWriterInvoker, Datadog_sdk_android")]
		void IncrementTraceCount ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.common.writer']/interface[@name='Writer']/method[@name='start' and count(parameter)=0]"
		[Register ("start", "()V", "GetStartHandler:Com.Datadog.Trace.Common.Writer.IWriterInvoker, Datadog_sdk_android")]
		void Start ();

	}

	[global::Android.Runtime.Register ("com/datadog/trace/common/writer/Writer", DoNotGenerateAcw=true)]
	internal partial class IWriterInvoker : global::Java.Lang.Object, IWriter {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/trace/common/writer/Writer", typeof (IWriterInvoker));

		static IntPtr java_class_ref {
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
			get { return class_ref; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IWriter GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IWriter> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.datadog.trace.common.writer.Writer'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IWriterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Common.Writer.IWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		IntPtr id_close;
		public unsafe void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_close);
		}

		static Delegate cb_incrementTraceCount;
#pragma warning disable 0169
		static Delegate GetIncrementTraceCountHandler ()
		{
			if (cb_incrementTraceCount == null)
				cb_incrementTraceCount = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_IncrementTraceCount);
			return cb_incrementTraceCount;
		}

		static void n_IncrementTraceCount (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Common.Writer.IWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.IncrementTraceCount ();
		}
#pragma warning restore 0169

		IntPtr id_incrementTraceCount;
		public unsafe void IncrementTraceCount ()
		{
			if (id_incrementTraceCount == IntPtr.Zero)
				id_incrementTraceCount = JNIEnv.GetMethodID (class_ref, "incrementTraceCount", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_incrementTraceCount);
		}

		static Delegate cb_start;
#pragma warning disable 0169
		static Delegate GetStartHandler ()
		{
			if (cb_start == null)
				cb_start = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Start);
			return cb_start;
		}

		static void n_Start (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Common.Writer.IWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Start ();
		}
#pragma warning restore 0169

		IntPtr id_start;
		public unsafe void Start ()
		{
			if (id_start == IntPtr.Zero)
				id_start = JNIEnv.GetMethodID (class_ref, "start", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_start);
		}

	}
}
