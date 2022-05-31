using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Datadog.Opentracing.Jfr {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.opentracing.jfr']/class[@name='DDNoopScopeEvent']"
	[global::Android.Runtime.Register ("com/datadog/opentracing/jfr/DDNoopScopeEvent", DoNotGenerateAcw=true)]
	public sealed partial class DDNoopScopeEvent : global::Java.Lang.Object, global::Com.Datadog.Opentracing.Jfr.IDDScopeEvent {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.opentracing.jfr']/class[@name='DDNoopScopeEvent']/field[@name='INSTANCE']"
		[Register ("INSTANCE")]
		public static global::Com.Datadog.Opentracing.Jfr.DDNoopScopeEvent Instance {
			get {
				const string __id = "INSTANCE.Lcom/datadog/opentracing/jfr/DDNoopScopeEvent;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Opentracing.Jfr.DDNoopScopeEvent> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/opentracing/jfr/DDNoopScopeEvent", typeof (DDNoopScopeEvent));

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

		internal DDNoopScopeEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.opentracing.jfr']/class[@name='DDNoopScopeEvent']/constructor[@name='DDNoopScopeEvent' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DDNoopScopeEvent () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.opentracing.jfr']/class[@name='DDNoopScopeEvent']/method[@name='finish' and count(parameter)=0]"
		[Register ("finish", "()V", "")]
		public unsafe void Finish ()
		{
			const string __id = "finish.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.opentracing.jfr']/class[@name='DDNoopScopeEvent']/method[@name='start' and count(parameter)=0]"
		[Register ("start", "()V", "")]
		public unsafe void Start ()
		{
			const string __id = "start.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
