using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Datadog.Opentracing.Propagation {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.opentracing.propagation']/class[@name='HttpCodec']"
	[global::Android.Runtime.Register ("com/datadog/opentracing/propagation/HttpCodec", DoNotGenerateAcw=true)]
	public partial class HttpCodec : global::Java.Lang.Object {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.opentracing.propagation']/class[@name='HttpCodec.CompoundExtractor']"
		[global::Android.Runtime.Register ("com/datadog/opentracing/propagation/HttpCodec$CompoundExtractor", DoNotGenerateAcw=true)]
		public partial class CompoundExtractor : global::Java.Lang.Object, global::Com.Datadog.Opentracing.Propagation.HttpCodec.IExtractor {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/opentracing/propagation/HttpCodec$CompoundExtractor", typeof (CompoundExtractor));

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

			protected CompoundExtractor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.opentracing.propagation']/class[@name='HttpCodec.CompoundExtractor']/constructor[@name='HttpCodec.CompoundExtractor' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.datadog.opentracing.propagation.HttpCodec.Extractor&gt;']]"
			[Register (".ctor", "(Ljava/util/List;)V", "")]
			public unsafe CompoundExtractor (global::System.Collections.Generic.IList<global::Com.Datadog.Opentracing.Propagation.HttpCodec.IExtractor> extractors) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/util/List;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_extractors = global::Android.Runtime.JavaList<global::Com.Datadog.Opentracing.Propagation.HttpCodec.IExtractor>.ToLocalJniHandle (extractors);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_extractors);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_extractors);
					global::System.GC.KeepAlive (extractors);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.opentracing.propagation']/class[@name='HttpCodec.CompoundInjector']"
		[global::Android.Runtime.Register ("com/datadog/opentracing/propagation/HttpCodec$CompoundInjector", DoNotGenerateAcw=true)]
		public partial class CompoundInjector : global::Java.Lang.Object, global::Com.Datadog.Opentracing.Propagation.HttpCodec.IInjector {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/opentracing/propagation/HttpCodec$CompoundInjector", typeof (CompoundInjector));

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

			protected CompoundInjector (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.opentracing.propagation']/class[@name='HttpCodec.CompoundInjector']/constructor[@name='HttpCodec.CompoundInjector' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.datadog.opentracing.propagation.HttpCodec.Injector&gt;']]"
			[Register (".ctor", "(Ljava/util/List;)V", "")]
			public unsafe CompoundInjector (global::System.Collections.Generic.IList<global::Com.Datadog.Opentracing.Propagation.HttpCodec.IInjector> injectors) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/util/List;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_injectors = global::Android.Runtime.JavaList<global::Com.Datadog.Opentracing.Propagation.HttpCodec.IInjector>.ToLocalJniHandle (injectors);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_injectors);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_injectors);
					global::System.GC.KeepAlive (injectors);
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.datadog.opentracing.propagation']/interface[@name='HttpCodec.Extractor']"
		[Register ("com/datadog/opentracing/propagation/HttpCodec$Extractor", "", "Com.Datadog.Opentracing.Propagation.HttpCodec/IExtractorInvoker")]
		public partial interface IExtractor : IJavaObject, IJavaPeerable {
		}

		[global::Android.Runtime.Register ("com/datadog/opentracing/propagation/HttpCodec$Extractor", DoNotGenerateAcw=true)]
		internal partial class IExtractorInvoker : global::Java.Lang.Object, IExtractor {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/opentracing/propagation/HttpCodec$Extractor", typeof (IExtractorInvoker));

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

			public static IExtractor GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IExtractor> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.datadog.opentracing.propagation.HttpCodec.Extractor'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IExtractorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.datadog.opentracing.propagation']/interface[@name='HttpCodec.Injector']"
		[Register ("com/datadog/opentracing/propagation/HttpCodec$Injector", "", "Com.Datadog.Opentracing.Propagation.HttpCodec/IInjectorInvoker")]
		public partial interface IInjector : IJavaObject, IJavaPeerable {
		}

		[global::Android.Runtime.Register ("com/datadog/opentracing/propagation/HttpCodec$Injector", DoNotGenerateAcw=true)]
		internal partial class IInjectorInvoker : global::Java.Lang.Object, IInjector {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/opentracing/propagation/HttpCodec$Injector", typeof (IInjectorInvoker));

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

			public static IInjector GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IInjector> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.datadog.opentracing.propagation.HttpCodec.Injector'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IInjectorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/opentracing/propagation/HttpCodec", typeof (HttpCodec));

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

		protected HttpCodec (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.opentracing.propagation']/class[@name='HttpCodec']/constructor[@name='HttpCodec' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe HttpCodec () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.opentracing.propagation']/class[@name='HttpCodec']/method[@name='createExtractor' and count(parameter)=2 and parameter[1][@type='com.datadog.trace.api.Config'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("createExtractor", "(Lcom/datadog/trace/api/Config;Ljava/util/Map;)Lcom/datadog/opentracing/propagation/HttpCodec$Extractor;", "")]
		public static unsafe global::Com.Datadog.Opentracing.Propagation.HttpCodec.IExtractor CreateExtractor (global::Com.Datadog.Trace.Api.Config config, global::System.Collections.Generic.IDictionary<string, string> taggedHeaders)
		{
			const string __id = "createExtractor.(Lcom/datadog/trace/api/Config;Ljava/util/Map;)Lcom/datadog/opentracing/propagation/HttpCodec$Extractor;";
			IntPtr native_taggedHeaders = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (taggedHeaders);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((config == null) ? IntPtr.Zero : ((global::Java.Lang.Object) config).Handle);
				__args [1] = new JniArgumentValue (native_taggedHeaders);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Opentracing.Propagation.HttpCodec.IExtractor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_taggedHeaders);
				global::System.GC.KeepAlive (config);
				global::System.GC.KeepAlive (taggedHeaders);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.opentracing.propagation']/class[@name='HttpCodec']/method[@name='createInjector' and count(parameter)=1 and parameter[1][@type='com.datadog.trace.api.Config']]"
		[Register ("createInjector", "(Lcom/datadog/trace/api/Config;)Lcom/datadog/opentracing/propagation/HttpCodec$Injector;", "")]
		public static unsafe global::Com.Datadog.Opentracing.Propagation.HttpCodec.IInjector CreateInjector (global::Com.Datadog.Trace.Api.Config config)
		{
			const string __id = "createInjector.(Lcom/datadog/trace/api/Config;)Lcom/datadog/opentracing/propagation/HttpCodec$Injector;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((config == null) ? IntPtr.Zero : ((global::Java.Lang.Object) config).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Opentracing.Propagation.HttpCodec.IInjector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (config);
			}
		}

	}
}
