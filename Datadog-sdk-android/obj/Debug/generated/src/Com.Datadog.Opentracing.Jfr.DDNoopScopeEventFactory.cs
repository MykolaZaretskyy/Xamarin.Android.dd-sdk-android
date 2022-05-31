using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Datadog.Opentracing.Jfr {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.opentracing.jfr']/class[@name='DDNoopScopeEventFactory']"
	[global::Android.Runtime.Register ("com/datadog/opentracing/jfr/DDNoopScopeEventFactory", DoNotGenerateAcw=true)]
	public sealed partial class DDNoopScopeEventFactory : global::Java.Lang.Object, global::Com.Datadog.Opentracing.Jfr.IDDScopeEventFactory {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/opentracing/jfr/DDNoopScopeEventFactory", typeof (DDNoopScopeEventFactory));

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

		internal DDNoopScopeEventFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.opentracing.jfr']/class[@name='DDNoopScopeEventFactory']/constructor[@name='DDNoopScopeEventFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DDNoopScopeEventFactory () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

	}
}
