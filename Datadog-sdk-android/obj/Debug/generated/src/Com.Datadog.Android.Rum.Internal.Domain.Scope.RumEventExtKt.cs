using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Datadog.Android.Rum.Internal.Domain.Scope {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.internal.domain.scope']/class[@name='RumEventExtKt']"
	[global::Android.Runtime.Register ("com/datadog/android/rum/internal/domain/scope/RumEventExtKt", DoNotGenerateAcw=true)]
	public sealed partial class RumEventExtKt : global::Java.Lang.Object {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.internal.domain.scope']/class[@name='RumEventExtKt.WhenMappings']"
		[global::Android.Runtime.Register ("com/datadog/android/rum/internal/domain/scope/RumEventExtKt$WhenMappings", DoNotGenerateAcw=true)]
		public sealed partial class WhenMappings : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/internal/domain/scope/RumEventExtKt$WhenMappings", typeof (WhenMappings));

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

			internal WhenMappings (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/internal/domain/scope/RumEventExtKt", typeof (RumEventExtKt));

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

		internal RumEventExtKt (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.internal.domain.scope']/class[@name='RumEventExtKt']/method[@name='connect' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("connect", "(Ljava/lang/Object;)Lcom/datadog/android/rum/model/ResourceEvent$Connect;", "")]
		public static unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.Connect Connect (global::Java.Lang.Object obj)
		{
			const string __id = "connect.(Ljava/lang/Object;)Lcom/datadog/android/rum/model/ResourceEvent$Connect;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Connect> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (obj);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.internal.domain.scope']/class[@name='RumEventExtKt']/method[@name='dns' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("dns", "(Ljava/lang/Object;)Lcom/datadog/android/rum/model/ResourceEvent$Dns;", "")]
		public static unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.Dns Dns (global::Java.Lang.Object obj)
		{
			const string __id = "dns.(Ljava/lang/Object;)Lcom/datadog/android/rum/model/ResourceEvent$Dns;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Dns> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (obj);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.internal.domain.scope']/class[@name='RumEventExtKt']/method[@name='download' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("download", "(Ljava/lang/Object;)Lcom/datadog/android/rum/model/ResourceEvent$Download;", "")]
		public static unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.Download Download (global::Java.Lang.Object obj)
		{
			const string __id = "download.(Ljava/lang/Object;)Lcom/datadog/android/rum/model/ResourceEvent$Download;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Download> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (obj);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.internal.domain.scope']/class[@name='RumEventExtKt']/method[@name='firstByte' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("firstByte", "(Ljava/lang/Object;)Lcom/datadog/android/rum/model/ResourceEvent$FirstByte;", "")]
		public static unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.FirstByte FirstByte (global::Java.Lang.Object obj)
		{
			const string __id = "firstByte.(Ljava/lang/Object;)Lcom/datadog/android/rum/model/ResourceEvent$FirstByte;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.FirstByte> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (obj);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.internal.domain.scope']/class[@name='RumEventExtKt']/method[@name='ssl' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("ssl", "(Ljava/lang/Object;)Lcom/datadog/android/rum/model/ResourceEvent$Ssl;", "")]
		public static unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.Ssl Ssl (global::Java.Lang.Object obj)
		{
			const string __id = "ssl.(Ljava/lang/Object;)Lcom/datadog/android/rum/model/ResourceEvent$Ssl;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Ssl> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (obj);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.internal.domain.scope']/class[@name='RumEventExtKt']/method[@name='toErrorConnectivity' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("toErrorConnectivity", "(Ljava/lang/Object;)Lcom/datadog/android/rum/model/ErrorEvent$Connectivity;", "")]
		public static unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent.Connectivity ToErrorConnectivity (global::Java.Lang.Object obj)
		{
			const string __id = "toErrorConnectivity.(Ljava/lang/Object;)Lcom/datadog/android/rum/model/ErrorEvent$Connectivity;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Connectivity> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (obj);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.internal.domain.scope']/class[@name='RumEventExtKt']/method[@name='toErrorMethod' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("toErrorMethod", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent$Method;", "")]
		public static unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent.Method ToErrorMethod (string obj)
		{
			const string __id = "toErrorMethod.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent$Method;";
			IntPtr native_obj = JNIEnv.NewString (obj);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_obj);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Method> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_obj);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.internal.domain.scope']/class[@name='RumEventExtKt']/method[@name='toMethod' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("toMethod", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$Method;", "")]
		public static unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.Method ToMethod (string obj)
		{
			const string __id = "toMethod.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$Method;";
			IntPtr native_obj = JNIEnv.NewString (obj);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_obj);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Method> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_obj);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.internal.domain.scope']/class[@name='RumEventExtKt']/method[@name='toResourceConnectivity' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("toResourceConnectivity", "(Ljava/lang/Object;)Lcom/datadog/android/rum/model/ResourceEvent$Connectivity;", "")]
		public static unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.Connectivity ToResourceConnectivity (global::Java.Lang.Object obj)
		{
			const string __id = "toResourceConnectivity.(Ljava/lang/Object;)Lcom/datadog/android/rum/model/ResourceEvent$Connectivity;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Connectivity> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (obj);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.internal.domain.scope']/class[@name='RumEventExtKt']/method[@name='toSchemaSource' and count(parameter)=1 and parameter[1][@type='com.datadog.android.rum.RumErrorSource']]"
		[Register ("toSchemaSource", "(Lcom/datadog/android/rum/RumErrorSource;)Lcom/datadog/android/rum/model/ErrorEvent$Source;", "")]
		public static unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent.Source ToSchemaSource (global::Com.Datadog.Android.Rum.RumErrorSource obj)
		{
			const string __id = "toSchemaSource.(Lcom/datadog/android/rum/RumErrorSource;)Lcom/datadog/android/rum/model/ErrorEvent$Source;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Source> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (obj);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.internal.domain.scope']/class[@name='RumEventExtKt']/method[@name='toSchemaType' and count(parameter)=1 and parameter[1][@type='com.datadog.android.rum.RumActionType']]"
		[Register ("toSchemaType", "(Lcom/datadog/android/rum/RumActionType;)Lcom/datadog/android/rum/model/ActionEvent$ActionType;", "")]
		public static unsafe global::Com.Datadog.Android.Rum.Model.ActionEvent.ActionType ToSchemaType (global::Com.Datadog.Android.Rum.RumActionType obj)
		{
			const string __id = "toSchemaType.(Lcom/datadog/android/rum/RumActionType;)Lcom/datadog/android/rum/model/ActionEvent$ActionType;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.ActionType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (obj);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.internal.domain.scope']/class[@name='RumEventExtKt']/method[@name='toSchemaType' and count(parameter)=1 and parameter[1][@type='com.datadog.android.rum.RumResourceKind']]"
		[Register ("toSchemaType", "(Lcom/datadog/android/rum/RumResourceKind;)Lcom/datadog/android/rum/model/ResourceEvent$ResourceType;", "")]
		public static unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.ResourceType ToSchemaType (global::Com.Datadog.Android.Rum.RumResourceKind obj)
		{
			const string __id = "toSchemaType.(Lcom/datadog/android/rum/RumResourceKind;)Lcom/datadog/android/rum/model/ResourceEvent$ResourceType;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.ResourceType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (obj);
			}
		}

	}
}
