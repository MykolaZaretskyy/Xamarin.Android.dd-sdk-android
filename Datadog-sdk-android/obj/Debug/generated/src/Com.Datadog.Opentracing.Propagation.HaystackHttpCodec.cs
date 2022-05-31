using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Datadog.Opentracing.Propagation {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.opentracing.propagation']/class[@name='HaystackHttpCodec']"
	[global::Android.Runtime.Register ("com/datadog/opentracing/propagation/HaystackHttpCodec", DoNotGenerateAcw=true)]
	public partial class HaystackHttpCodec : global::Java.Lang.Object {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.opentracing.propagation']/class[@name='HaystackHttpCodec.Extractor']"
		[global::Android.Runtime.Register ("com/datadog/opentracing/propagation/HaystackHttpCodec$Extractor", DoNotGenerateAcw=true)]
		public partial class Extractor : global::Java.Lang.Object, global::Com.Datadog.Opentracing.Propagation.HttpCodec.IExtractor {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/opentracing/propagation/HaystackHttpCodec$Extractor", typeof (Extractor));

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

			protected Extractor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.opentracing.propagation']/class[@name='HaystackHttpCodec.Extractor']/constructor[@name='HaystackHttpCodec.Extractor' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
			[Register (".ctor", "(Ljava/util/Map;)V", "")]
			public unsafe Extractor (global::System.Collections.Generic.IDictionary<string, string> taggedHeaders) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/util/Map;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_taggedHeaders = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (taggedHeaders);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_taggedHeaders);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_taggedHeaders);
					global::System.GC.KeepAlive (taggedHeaders);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.opentracing.propagation']/class[@name='HaystackHttpCodec.Injector']"
		[global::Android.Runtime.Register ("com/datadog/opentracing/propagation/HaystackHttpCodec$Injector", DoNotGenerateAcw=true)]
		public partial class Injector : global::Java.Lang.Object, global::Com.Datadog.Opentracing.Propagation.HttpCodec.IInjector {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/opentracing/propagation/HaystackHttpCodec$Injector", typeof (Injector));

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

			protected Injector (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.opentracing.propagation']/class[@name='HaystackHttpCodec.Injector']/constructor[@name='HaystackHttpCodec.Injector' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Injector () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/opentracing/propagation/HaystackHttpCodec", typeof (HaystackHttpCodec));

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

		protected HaystackHttpCodec (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

	}
}
