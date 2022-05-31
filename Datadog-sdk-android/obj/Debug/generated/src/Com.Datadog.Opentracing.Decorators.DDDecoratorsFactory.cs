using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Datadog.Opentracing.Decorators {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.opentracing.decorators']/class[@name='DDDecoratorsFactory']"
	[global::Android.Runtime.Register ("com/datadog/opentracing/decorators/DDDecoratorsFactory", DoNotGenerateAcw=true)]
	public partial class DDDecoratorsFactory : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/opentracing/decorators/DDDecoratorsFactory", typeof (DDDecoratorsFactory));

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

		protected DDDecoratorsFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.opentracing.decorators']/class[@name='DDDecoratorsFactory']/constructor[@name='DDDecoratorsFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DDDecoratorsFactory () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.opentracing.decorators']/class[@name='DDDecoratorsFactory']/method[@name='createBuiltinDecorators' and count(parameter)=0]"
		[Register ("createBuiltinDecorators", "()Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Com.Datadog.Opentracing.Decorators.AbstractDecorator> CreateBuiltinDecorators ()
		{
			const string __id = "createBuiltinDecorators.()Ljava/util/List;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Android.Runtime.JavaList<global::Com.Datadog.Opentracing.Decorators.AbstractDecorator>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
