using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Datadog.Android.Rum.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent']"
	[global::Android.Runtime.Register ("com/datadog/android/rum/model/ViewEvent", DoNotGenerateAcw=true)]
	public sealed partial class ViewEvent : global::Java.Lang.Object {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Action']"
		[global::Android.Runtime.Register ("com/datadog/android/rum/model/ViewEvent$Action", DoNotGenerateAcw=true)]
		public sealed partial class Action : global::Java.Lang.Object {
			// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Action.Companion']"
			[global::Android.Runtime.Register ("com/datadog/android/rum/model/ViewEvent$Action$Companion", DoNotGenerateAcw=true)]
			public sealed partial class Companion : global::Java.Lang.Object {
				static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ViewEvent$Action$Companion", typeof (Companion));

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

				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Action.Companion']/constructor[@name='ViewEvent.Action.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
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

				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Action.Companion']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ViewEvent$Action;", "")]
				public unsafe global::Com.Datadog.Android.Rum.Model.ViewEvent.Action FromJson (string serializedObject)
				{
					const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ViewEvent$Action;";
					IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_serializedObject);
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.Action> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
						JNIEnv.DeleteLocalRef (native_serializedObject);
					}
				}

			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ViewEvent$Action", typeof (Action));

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

			internal Action (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Action']/constructor[@name='ViewEvent.Action' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register (".ctor", "(J)V", "")]
			public unsafe Action (long count) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(J)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (count);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			public unsafe long Count {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Action']/method[@name='getCount' and count(parameter)=0]"
				[Register ("getCount", "()J", "")]
				get {
					const string __id = "getCount.()J";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualInt64Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Action']/method[@name='component1' and count(parameter)=0]"
			[Register ("component1", "()J", "")]
			public unsafe long Component1 ()
			{
				const string __id = "component1.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Action']/method[@name='copy' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("copy", "(J)Lcom/datadog/android/rum/model/ViewEvent$Action;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ViewEvent.Action Copy (long count)
			{
				const string __id = "copy.(J)Lcom/datadog/android/rum/model/ViewEvent$Action;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (count);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.Action> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Action']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ViewEvent$Action;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ViewEvent.Action FromJson (string serializedObject)
			{
				const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ViewEvent$Action;";
				IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_serializedObject);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.Action> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_serializedObject);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Application']"
		[global::Android.Runtime.Register ("com/datadog/android/rum/model/ViewEvent$Application", DoNotGenerateAcw=true)]
		public sealed partial class Application : global::Java.Lang.Object {
			// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Application.Companion']"
			[global::Android.Runtime.Register ("com/datadog/android/rum/model/ViewEvent$Application$Companion", DoNotGenerateAcw=true)]
			public sealed partial class Companion : global::Java.Lang.Object {
				static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ViewEvent$Application$Companion", typeof (Companion));

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

				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Application.Companion']/constructor[@name='ViewEvent.Application.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
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

				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Application.Companion']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ViewEvent$Application;", "")]
				public unsafe global::Com.Datadog.Android.Rum.Model.ViewEvent.Application FromJson (string serializedObject)
				{
					const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ViewEvent$Application;";
					IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_serializedObject);
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.Application> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
						JNIEnv.DeleteLocalRef (native_serializedObject);
					}
				}

			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ViewEvent$Application", typeof (Application));

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

			internal Application (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Application']/constructor[@name='ViewEvent.Application' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register (".ctor", "(Ljava/lang/String;)V", "")]
			public unsafe Application (string id) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/String;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_id = JNIEnv.NewString (id);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_id);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_id);
				}
			}

			public unsafe string Id {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Application']/method[@name='getId' and count(parameter)=0]"
				[Register ("getId", "()Ljava/lang/String;", "")]
				get {
					const string __id = "getId.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Application']/method[@name='component1' and count(parameter)=0]"
			[Register ("component1", "()Ljava/lang/String;", "")]
			public unsafe string Component1 ()
			{
				const string __id = "component1.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Application']/method[@name='copy' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("copy", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ViewEvent$Application;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ViewEvent.Application Copy (string id)
			{
				const string __id = "copy.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ViewEvent$Application;";
				IntPtr native_id = JNIEnv.NewString (id);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_id);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.Application> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_id);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Application']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ViewEvent$Application;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ViewEvent.Application FromJson (string serializedObject)
			{
				const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ViewEvent$Application;";
				IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_serializedObject);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.Application> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_serializedObject);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Cellular']"
		[global::Android.Runtime.Register ("com/datadog/android/rum/model/ViewEvent$Cellular", DoNotGenerateAcw=true)]
		public sealed partial class Cellular : global::Java.Lang.Object {
			// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Cellular.Companion']"
			[global::Android.Runtime.Register ("com/datadog/android/rum/model/ViewEvent$Cellular$Companion", DoNotGenerateAcw=true)]
			public sealed partial class Companion : global::Java.Lang.Object {
				static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ViewEvent$Cellular$Companion", typeof (Companion));

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

				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Cellular.Companion']/constructor[@name='ViewEvent.Cellular.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
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

				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Cellular.Companion']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ViewEvent$Cellular;", "")]
				public unsafe global::Com.Datadog.Android.Rum.Model.ViewEvent.Cellular FromJson (string serializedObject)
				{
					const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ViewEvent$Cellular;";
					IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_serializedObject);
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.Cellular> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
						JNIEnv.DeleteLocalRef (native_serializedObject);
					}
				}

			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ViewEvent$Cellular", typeof (Cellular));

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

			internal Cellular (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Cellular']/constructor[@name='ViewEvent.Cellular' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Cellular () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Cellular']/constructor[@name='ViewEvent.Cellular' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
			public unsafe Cellular (string technology, string carrierName) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/String;Ljava/lang/String;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_technology = JNIEnv.NewString (technology);
				IntPtr native_carrierName = JNIEnv.NewString (carrierName);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_technology);
					__args [1] = new JniArgumentValue (native_carrierName);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_technology);
					JNIEnv.DeleteLocalRef (native_carrierName);
				}
			}

			public unsafe string CarrierName {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Cellular']/method[@name='getCarrierName' and count(parameter)=0]"
				[Register ("getCarrierName", "()Ljava/lang/String;", "")]
				get {
					const string __id = "getCarrierName.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe string Technology {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Cellular']/method[@name='getTechnology' and count(parameter)=0]"
				[Register ("getTechnology", "()Ljava/lang/String;", "")]
				get {
					const string __id = "getTechnology.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Cellular']/method[@name='component1' and count(parameter)=0]"
			[Register ("component1", "()Ljava/lang/String;", "")]
			public unsafe string Component1 ()
			{
				const string __id = "component1.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Cellular']/method[@name='component2' and count(parameter)=0]"
			[Register ("component2", "()Ljava/lang/String;", "")]
			public unsafe string Component2 ()
			{
				const string __id = "component2.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Cellular']/method[@name='copy' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register ("copy", "(Ljava/lang/String;Ljava/lang/String;)Lcom/datadog/android/rum/model/ViewEvent$Cellular;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ViewEvent.Cellular Copy (string technology, string carrierName)
			{
				const string __id = "copy.(Ljava/lang/String;Ljava/lang/String;)Lcom/datadog/android/rum/model/ViewEvent$Cellular;";
				IntPtr native_technology = JNIEnv.NewString (technology);
				IntPtr native_carrierName = JNIEnv.NewString (carrierName);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_technology);
					__args [1] = new JniArgumentValue (native_carrierName);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.Cellular> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_technology);
					JNIEnv.DeleteLocalRef (native_carrierName);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Cellular']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ViewEvent$Cellular;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ViewEvent.Cellular FromJson (string serializedObject)
			{
				const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ViewEvent$Cellular;";
				IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_serializedObject);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.Cellular> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_serializedObject);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Companion']"
		[global::Android.Runtime.Register ("com/datadog/android/rum/model/ViewEvent$Companion", DoNotGenerateAcw=true)]
		public sealed partial class Companion : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ViewEvent$Companion", typeof (Companion));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Companion']/constructor[@name='ViewEvent.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Companion']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ViewEvent;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ViewEvent FromJson (string serializedObject)
			{
				const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ViewEvent;";
				IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_serializedObject);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_serializedObject);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Connectivity']"
		[global::Android.Runtime.Register ("com/datadog/android/rum/model/ViewEvent$Connectivity", DoNotGenerateAcw=true)]
		public sealed partial class Connectivity : global::Java.Lang.Object {
			// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Connectivity.Companion']"
			[global::Android.Runtime.Register ("com/datadog/android/rum/model/ViewEvent$Connectivity$Companion", DoNotGenerateAcw=true)]
			public sealed partial class Companion : global::Java.Lang.Object {
				static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ViewEvent$Connectivity$Companion", typeof (Companion));

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

				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Connectivity.Companion']/constructor[@name='ViewEvent.Connectivity.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
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

				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Connectivity.Companion']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ViewEvent$Connectivity;", "")]
				public unsafe global::Com.Datadog.Android.Rum.Model.ViewEvent.Connectivity FromJson (string serializedObject)
				{
					const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ViewEvent$Connectivity;";
					IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_serializedObject);
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.Connectivity> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
						JNIEnv.DeleteLocalRef (native_serializedObject);
					}
				}

			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ViewEvent$Connectivity", typeof (Connectivity));

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

			internal Connectivity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Connectivity']/constructor[@name='ViewEvent.Connectivity' and count(parameter)=3 and parameter[1][@type='com.datadog.android.rum.model.ViewEvent.Status'] and parameter[2][@type='java.util.List&lt;? extends com.datadog.android.rum.model.ViewEvent.Interface&gt;'] and parameter[3][@type='com.datadog.android.rum.model.ViewEvent.Cellular']]"
			[Register (".ctor", "(Lcom/datadog/android/rum/model/ViewEvent$Status;Ljava/util/List;Lcom/datadog/android/rum/model/ViewEvent$Cellular;)V", "")]
			public unsafe Connectivity (global::Com.Datadog.Android.Rum.Model.ViewEvent.Status status, global::System.Collections.Generic.IList<global::Com.Datadog.Android.Rum.Model.ViewEvent.Interface> interfaces, global::Com.Datadog.Android.Rum.Model.ViewEvent.Cellular cellular) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Lcom/datadog/android/rum/model/ViewEvent$Status;Ljava/util/List;Lcom/datadog/android/rum/model/ViewEvent$Cellular;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_interfaces = global::Android.Runtime.JavaList<global::Com.Datadog.Android.Rum.Model.ViewEvent.Interface>.ToLocalJniHandle (interfaces);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue ((status == null) ? IntPtr.Zero : ((global::Java.Lang.Object) status).Handle);
					__args [1] = new JniArgumentValue (native_interfaces);
					__args [2] = new JniArgumentValue ((cellular == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cellular).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_interfaces);
					global::System.GC.KeepAlive (status);
					global::System.GC.KeepAlive (interfaces);
					global::System.GC.KeepAlive (cellular);
				}
			}

			public unsafe global::Com.Datadog.Android.Rum.Model.ViewEvent.Cellular Cellular {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Connectivity']/method[@name='getCellular' and count(parameter)=0]"
				[Register ("getCellular", "()Lcom/datadog/android/rum/model/ViewEvent$Cellular;", "")]
				get {
					const string __id = "getCellular.()Lcom/datadog/android/rum/model/ViewEvent$Cellular;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.Cellular> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe global::System.Collections.Generic.IList<global::Com.Datadog.Android.Rum.Model.ViewEvent.Interface> Interfaces {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Connectivity']/method[@name='getInterfaces' and count(parameter)=0]"
				[Register ("getInterfaces", "()Ljava/util/List;", "")]
				get {
					const string __id = "getInterfaces.()Ljava/util/List;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Android.Runtime.JavaList<global::Com.Datadog.Android.Rum.Model.ViewEvent.Interface>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe global::Com.Datadog.Android.Rum.Model.ViewEvent.Status Status {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Connectivity']/method[@name='getStatus' and count(parameter)=0]"
				[Register ("getStatus", "()Lcom/datadog/android/rum/model/ViewEvent$Status;", "")]
				get {
					const string __id = "getStatus.()Lcom/datadog/android/rum/model/ViewEvent$Status;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.Status> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Connectivity']/method[@name='component1' and count(parameter)=0]"
			[Register ("component1", "()Lcom/datadog/android/rum/model/ViewEvent$Status;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ViewEvent.Status Component1 ()
			{
				const string __id = "component1.()Lcom/datadog/android/rum/model/ViewEvent$Status;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.Status> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Connectivity']/method[@name='component2' and count(parameter)=0]"
			[Register ("component2", "()Ljava/util/List;", "")]
			public unsafe global::System.Collections.Generic.IList<global::Com.Datadog.Android.Rum.Model.ViewEvent.Interface> Component2 ()
			{
				const string __id = "component2.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Datadog.Android.Rum.Model.ViewEvent.Interface>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Connectivity']/method[@name='component3' and count(parameter)=0]"
			[Register ("component3", "()Lcom/datadog/android/rum/model/ViewEvent$Cellular;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ViewEvent.Cellular Component3 ()
			{
				const string __id = "component3.()Lcom/datadog/android/rum/model/ViewEvent$Cellular;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.Cellular> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Connectivity']/method[@name='copy' and count(parameter)=3 and parameter[1][@type='com.datadog.android.rum.model.ViewEvent.Status'] and parameter[2][@type='java.util.List&lt;? extends com.datadog.android.rum.model.ViewEvent.Interface&gt;'] and parameter[3][@type='com.datadog.android.rum.model.ViewEvent.Cellular']]"
			[Register ("copy", "(Lcom/datadog/android/rum/model/ViewEvent$Status;Ljava/util/List;Lcom/datadog/android/rum/model/ViewEvent$Cellular;)Lcom/datadog/android/rum/model/ViewEvent$Connectivity;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ViewEvent.Connectivity Copy (global::Com.Datadog.Android.Rum.Model.ViewEvent.Status status, global::System.Collections.Generic.IList<global::Com.Datadog.Android.Rum.Model.ViewEvent.Interface> interfaces, global::Com.Datadog.Android.Rum.Model.ViewEvent.Cellular cellular)
			{
				const string __id = "copy.(Lcom/datadog/android/rum/model/ViewEvent$Status;Ljava/util/List;Lcom/datadog/android/rum/model/ViewEvent$Cellular;)Lcom/datadog/android/rum/model/ViewEvent$Connectivity;";
				IntPtr native_interfaces = global::Android.Runtime.JavaList<global::Com.Datadog.Android.Rum.Model.ViewEvent.Interface>.ToLocalJniHandle (interfaces);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue ((status == null) ? IntPtr.Zero : ((global::Java.Lang.Object) status).Handle);
					__args [1] = new JniArgumentValue (native_interfaces);
					__args [2] = new JniArgumentValue ((cellular == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cellular).Handle);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.Connectivity> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_interfaces);
					global::System.GC.KeepAlive (status);
					global::System.GC.KeepAlive (interfaces);
					global::System.GC.KeepAlive (cellular);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Connectivity']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ViewEvent$Connectivity;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ViewEvent.Connectivity FromJson (string serializedObject)
			{
				const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ViewEvent$Connectivity;";
				IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_serializedObject);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.Connectivity> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_serializedObject);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Crash']"
		[global::Android.Runtime.Register ("com/datadog/android/rum/model/ViewEvent$Crash", DoNotGenerateAcw=true)]
		public sealed partial class Crash : global::Java.Lang.Object {
			// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Crash.Companion']"
			[global::Android.Runtime.Register ("com/datadog/android/rum/model/ViewEvent$Crash$Companion", DoNotGenerateAcw=true)]
			public sealed partial class Companion : global::Java.Lang.Object {
				static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ViewEvent$Crash$Companion", typeof (Companion));

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

				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Crash.Companion']/constructor[@name='ViewEvent.Crash.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
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

				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Crash.Companion']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ViewEvent$Crash;", "")]
				public unsafe global::Com.Datadog.Android.Rum.Model.ViewEvent.Crash FromJson (string serializedObject)
				{
					const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ViewEvent$Crash;";
					IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_serializedObject);
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.Crash> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
						JNIEnv.DeleteLocalRef (native_serializedObject);
					}
				}

			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ViewEvent$Crash", typeof (Crash));

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

			internal Crash (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Crash']/constructor[@name='ViewEvent.Crash' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register (".ctor", "(J)V", "")]
			public unsafe Crash (long count) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(J)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (count);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			public unsafe long Count {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Crash']/method[@name='getCount' and count(parameter)=0]"
				[Register ("getCount", "()J", "")]
				get {
					const string __id = "getCount.()J";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualInt64Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Crash']/method[@name='component1' and count(parameter)=0]"
			[Register ("component1", "()J", "")]
			public unsafe long Component1 ()
			{
				const string __id = "component1.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Crash']/method[@name='copy' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("copy", "(J)Lcom/datadog/android/rum/model/ViewEvent$Crash;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ViewEvent.Crash Copy (long count)
			{
				const string __id = "copy.(J)Lcom/datadog/android/rum/model/ViewEvent$Crash;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (count);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.Crash> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Crash']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ViewEvent$Crash;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ViewEvent.Crash FromJson (string serializedObject)
			{
				const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ViewEvent$Crash;";
				IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_serializedObject);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.Crash> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_serializedObject);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.CustomTimings']"
		[global::Android.Runtime.Register ("com/datadog/android/rum/model/ViewEvent$CustomTimings", DoNotGenerateAcw=true)]
		public sealed partial class CustomTimings : global::Java.Lang.Object {
			// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.CustomTimings.Companion']"
			[global::Android.Runtime.Register ("com/datadog/android/rum/model/ViewEvent$CustomTimings$Companion", DoNotGenerateAcw=true)]
			public sealed partial class Companion : global::Java.Lang.Object {
				static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ViewEvent$CustomTimings$Companion", typeof (Companion));

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

				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.CustomTimings.Companion']/constructor[@name='ViewEvent.CustomTimings.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
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

				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.CustomTimings.Companion']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ViewEvent$CustomTimings;", "")]
				public unsafe global::Com.Datadog.Android.Rum.Model.ViewEvent.CustomTimings FromJson (string serializedObject)
				{
					const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ViewEvent$CustomTimings;";
					IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_serializedObject);
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.CustomTimings> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
						JNIEnv.DeleteLocalRef (native_serializedObject);
					}
				}

			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ViewEvent$CustomTimings", typeof (CustomTimings));

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

			internal CustomTimings (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.CustomTimings']/constructor[@name='ViewEvent.CustomTimings' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe CustomTimings () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.CustomTimings']/constructor[@name='ViewEvent.CustomTimings' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Long&gt;']]"
			[Register (".ctor", "(Ljava/util/Map;)V", "")]
			public unsafe CustomTimings (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Long> additionalProperties) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/util/Map;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_additionalProperties = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Long>.ToLocalJniHandle (additionalProperties);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_additionalProperties);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_additionalProperties);
					global::System.GC.KeepAlive (additionalProperties);
				}
			}

			public unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Long> AdditionalProperties {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.CustomTimings']/method[@name='getAdditionalProperties' and count(parameter)=0]"
				[Register ("getAdditionalProperties", "()Ljava/util/Map;", "")]
				get {
					const string __id = "getAdditionalProperties.()Ljava/util/Map;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Long>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.CustomTimings']/method[@name='component1' and count(parameter)=0]"
			[Register ("component1", "()Ljava/util/Map;", "")]
			public unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Long> Component1 ()
			{
				const string __id = "component1.()Ljava/util/Map;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Long>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.CustomTimings']/method[@name='copy' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Long&gt;']]"
			[Register ("copy", "(Ljava/util/Map;)Lcom/datadog/android/rum/model/ViewEvent$CustomTimings;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ViewEvent.CustomTimings Copy (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Long> additionalProperties)
			{
				const string __id = "copy.(Ljava/util/Map;)Lcom/datadog/android/rum/model/ViewEvent$CustomTimings;";
				IntPtr native_additionalProperties = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Long>.ToLocalJniHandle (additionalProperties);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_additionalProperties);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.CustomTimings> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_additionalProperties);
					global::System.GC.KeepAlive (additionalProperties);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.CustomTimings']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ViewEvent$CustomTimings;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ViewEvent.CustomTimings FromJson (string serializedObject)
			{
				const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ViewEvent$CustomTimings;";
				IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_serializedObject);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.CustomTimings> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_serializedObject);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Dd']"
		[global::Android.Runtime.Register ("com/datadog/android/rum/model/ViewEvent$Dd", DoNotGenerateAcw=true)]
		public sealed partial class Dd : global::Java.Lang.Object {
			// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Dd.Companion']"
			[global::Android.Runtime.Register ("com/datadog/android/rum/model/ViewEvent$Dd$Companion", DoNotGenerateAcw=true)]
			public sealed partial class Companion : global::Java.Lang.Object {
				static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ViewEvent$Dd$Companion", typeof (Companion));

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

				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Dd.Companion']/constructor[@name='ViewEvent.Dd.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
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

				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Dd.Companion']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ViewEvent$Dd;", "")]
				public unsafe global::Com.Datadog.Android.Rum.Model.ViewEvent.Dd FromJson (string serializedObject)
				{
					const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ViewEvent$Dd;";
					IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_serializedObject);
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.Dd> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
						JNIEnv.DeleteLocalRef (native_serializedObject);
					}
				}

			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ViewEvent$Dd", typeof (Dd));

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

			internal Dd (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Dd']/constructor[@name='ViewEvent.Dd' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register (".ctor", "(J)V", "")]
			public unsafe Dd (long documentVersion) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(J)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (documentVersion);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			public unsafe long DocumentVersion {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Dd']/method[@name='getDocumentVersion' and count(parameter)=0]"
				[Register ("getDocumentVersion", "()J", "")]
				get {
					const string __id = "getDocumentVersion.()J";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualInt64Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			public unsafe long FormatVersion {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Dd']/method[@name='getFormatVersion' and count(parameter)=0]"
				[Register ("getFormatVersion", "()J", "")]
				get {
					const string __id = "getFormatVersion.()J";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualInt64Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Dd']/method[@name='component1' and count(parameter)=0]"
			[Register ("component1", "()J", "")]
			public unsafe long Component1 ()
			{
				const string __id = "component1.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Dd']/method[@name='copy' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("copy", "(J)Lcom/datadog/android/rum/model/ViewEvent$Dd;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ViewEvent.Dd Copy (long documentVersion)
			{
				const string __id = "copy.(J)Lcom/datadog/android/rum/model/ViewEvent$Dd;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (documentVersion);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.Dd> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Dd']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ViewEvent$Dd;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ViewEvent.Dd FromJson (string serializedObject)
			{
				const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ViewEvent$Dd;";
				IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_serializedObject);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.Dd> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_serializedObject);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Error']"
		[global::Android.Runtime.Register ("com/datadog/android/rum/model/ViewEvent$Error", DoNotGenerateAcw=true)]
		public sealed partial class Error : global::Java.Lang.Object {
			// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Error.Companion']"
			[global::Android.Runtime.Register ("com/datadog/android/rum/model/ViewEvent$Error$Companion", DoNotGenerateAcw=true)]
			public sealed partial class Companion : global::Java.Lang.Object {
				static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ViewEvent$Error$Companion", typeof (Companion));

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

				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Error.Companion']/constructor[@name='ViewEvent.Error.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
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

				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Error.Companion']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ViewEvent$Error;", "")]
				public unsafe global::Com.Datadog.Android.Rum.Model.ViewEvent.Error FromJson (string serializedObject)
				{
					const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ViewEvent$Error;";
					IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_serializedObject);
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.Error> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
						JNIEnv.DeleteLocalRef (native_serializedObject);
					}
				}

			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ViewEvent$Error", typeof (Error));

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

			internal Error (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Error']/constructor[@name='ViewEvent.Error' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register (".ctor", "(J)V", "")]
			public unsafe Error (long count) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(J)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (count);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			public unsafe long Count {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Error']/method[@name='getCount' and count(parameter)=0]"
				[Register ("getCount", "()J", "")]
				get {
					const string __id = "getCount.()J";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualInt64Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Error']/method[@name='component1' and count(parameter)=0]"
			[Register ("component1", "()J", "")]
			public unsafe long Component1 ()
			{
				const string __id = "component1.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Error']/method[@name='copy' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("copy", "(J)Lcom/datadog/android/rum/model/ViewEvent$Error;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ViewEvent.Error Copy (long count)
			{
				const string __id = "copy.(J)Lcom/datadog/android/rum/model/ViewEvent$Error;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (count);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.Error> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Error']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ViewEvent$Error;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ViewEvent.Error FromJson (string serializedObject)
			{
				const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ViewEvent$Error;";
				IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_serializedObject);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.Error> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_serializedObject);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Interface']"
		[global::Android.Runtime.Register ("com/datadog/android/rum/model/ViewEvent$Interface", DoNotGenerateAcw=true)]
		public sealed partial class Interface : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Interface']/field[@name='BLUETOOTH']"
			[Register ("BLUETOOTH")]
			public static global::Com.Datadog.Android.Rum.Model.ViewEvent.Interface Bluetooth {
				get {
					const string __id = "BLUETOOTH.Lcom/datadog/android/rum/model/ViewEvent$Interface;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.Interface> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Interface']/field[@name='CELLULAR']"
			[Register ("CELLULAR")]
			public static global::Com.Datadog.Android.Rum.Model.ViewEvent.Interface Cellular {
				get {
					const string __id = "CELLULAR.Lcom/datadog/android/rum/model/ViewEvent$Interface;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.Interface> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Interface']/field[@name='ETHERNET']"
			[Register ("ETHERNET")]
			public static global::Com.Datadog.Android.Rum.Model.ViewEvent.Interface Ethernet {
				get {
					const string __id = "ETHERNET.Lcom/datadog/android/rum/model/ViewEvent$Interface;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.Interface> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Interface']/field[@name='MIXED']"
			[Register ("MIXED")]
			public static global::Com.Datadog.Android.Rum.Model.ViewEvent.Interface Mixed {
				get {
					const string __id = "MIXED.Lcom/datadog/android/rum/model/ViewEvent$Interface;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.Interface> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Interface']/field[@name='NONE']"
			[Register ("NONE")]
			public static global::Com.Datadog.Android.Rum.Model.ViewEvent.Interface None {
				get {
					const string __id = "NONE.Lcom/datadog/android/rum/model/ViewEvent$Interface;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.Interface> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Interface']/field[@name='OTHER']"
			[Register ("OTHER")]
			public static global::Com.Datadog.Android.Rum.Model.ViewEvent.Interface Other {
				get {
					const string __id = "OTHER.Lcom/datadog/android/rum/model/ViewEvent$Interface;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.Interface> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Interface']/field[@name='UNKNOWN']"
			[Register ("UNKNOWN")]
			public static global::Com.Datadog.Android.Rum.Model.ViewEvent.Interface Unknown {
				get {
					const string __id = "UNKNOWN.Lcom/datadog/android/rum/model/ViewEvent$Interface;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.Interface> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Interface']/field[@name='WIFI']"
			[Register ("WIFI")]
			public static global::Com.Datadog.Android.Rum.Model.ViewEvent.Interface Wifi {
				get {
					const string __id = "WIFI.Lcom/datadog/android/rum/model/ViewEvent$Interface;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.Interface> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Interface']/field[@name='WIMAX']"
			[Register ("WIMAX")]
			public static global::Com.Datadog.Android.Rum.Model.ViewEvent.Interface Wimax {
				get {
					const string __id = "WIMAX.Lcom/datadog/android/rum/model/ViewEvent$Interface;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.Interface> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Interface.Companion']"
			[global::Android.Runtime.Register ("com/datadog/android/rum/model/ViewEvent$Interface$Companion", DoNotGenerateAcw=true)]
			public sealed partial class Companion : global::Java.Lang.Object {
				static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ViewEvent$Interface$Companion", typeof (Companion));

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

				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Interface.Companion']/constructor[@name='ViewEvent.Interface.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
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

				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Interface.Companion']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ViewEvent$Interface;", "")]
				public unsafe global::Com.Datadog.Android.Rum.Model.ViewEvent.Interface FromJson (string serializedObject)
				{
					const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ViewEvent$Interface;";
					IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_serializedObject);
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.Interface> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
						JNIEnv.DeleteLocalRef (native_serializedObject);
					}
				}

			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ViewEvent$Interface", typeof (Interface));

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

			internal Interface (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Interface']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ViewEvent$Interface;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ViewEvent.Interface FromJson (string serializedObject)
			{
				const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ViewEvent$Interface;";
				IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_serializedObject);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.Interface> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_serializedObject);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Interface']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ViewEvent$Interface;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ViewEvent.Interface ValueOf (string p0)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ViewEvent$Interface;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.Interface> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Interface']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/datadog/android/rum/model/ViewEvent$Interface;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ViewEvent.Interface[] Values ()
			{
				const string __id = "values.()[Lcom/datadog/android/rum/model/ViewEvent$Interface;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Datadog.Android.Rum.Model.ViewEvent.Interface[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Datadog.Android.Rum.Model.ViewEvent.Interface));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.LoadingType']"
		[global::Android.Runtime.Register ("com/datadog/android/rum/model/ViewEvent$LoadingType", DoNotGenerateAcw=true)]
		public sealed partial class LoadingType : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.LoadingType']/field[@name='ACTIVITY_DISPLAY']"
			[Register ("ACTIVITY_DISPLAY")]
			public static global::Com.Datadog.Android.Rum.Model.ViewEvent.LoadingType ActivityDisplay {
				get {
					const string __id = "ACTIVITY_DISPLAY.Lcom/datadog/android/rum/model/ViewEvent$LoadingType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.LoadingType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.LoadingType']/field[@name='ACTIVITY_REDISPLAY']"
			[Register ("ACTIVITY_REDISPLAY")]
			public static global::Com.Datadog.Android.Rum.Model.ViewEvent.LoadingType ActivityRedisplay {
				get {
					const string __id = "ACTIVITY_REDISPLAY.Lcom/datadog/android/rum/model/ViewEvent$LoadingType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.LoadingType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.LoadingType']/field[@name='FRAGMENT_DISPLAY']"
			[Register ("FRAGMENT_DISPLAY")]
			public static global::Com.Datadog.Android.Rum.Model.ViewEvent.LoadingType FragmentDisplay {
				get {
					const string __id = "FRAGMENT_DISPLAY.Lcom/datadog/android/rum/model/ViewEvent$LoadingType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.LoadingType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.LoadingType']/field[@name='FRAGMENT_REDISPLAY']"
			[Register ("FRAGMENT_REDISPLAY")]
			public static global::Com.Datadog.Android.Rum.Model.ViewEvent.LoadingType FragmentRedisplay {
				get {
					const string __id = "FRAGMENT_REDISPLAY.Lcom/datadog/android/rum/model/ViewEvent$LoadingType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.LoadingType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.LoadingType']/field[@name='INITIAL_LOAD']"
			[Register ("INITIAL_LOAD")]
			public static global::Com.Datadog.Android.Rum.Model.ViewEvent.LoadingType InitialLoad {
				get {
					const string __id = "INITIAL_LOAD.Lcom/datadog/android/rum/model/ViewEvent$LoadingType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.LoadingType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.LoadingType']/field[@name='ROUTE_CHANGE']"
			[Register ("ROUTE_CHANGE")]
			public static global::Com.Datadog.Android.Rum.Model.ViewEvent.LoadingType RouteChange {
				get {
					const string __id = "ROUTE_CHANGE.Lcom/datadog/android/rum/model/ViewEvent$LoadingType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.LoadingType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.LoadingType']/field[@name='VIEW_CONTROLLER_DISPLAY']"
			[Register ("VIEW_CONTROLLER_DISPLAY")]
			public static global::Com.Datadog.Android.Rum.Model.ViewEvent.LoadingType ViewControllerDisplay {
				get {
					const string __id = "VIEW_CONTROLLER_DISPLAY.Lcom/datadog/android/rum/model/ViewEvent$LoadingType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.LoadingType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.LoadingType']/field[@name='VIEW_CONTROLLER_REDISPLAY']"
			[Register ("VIEW_CONTROLLER_REDISPLAY")]
			public static global::Com.Datadog.Android.Rum.Model.ViewEvent.LoadingType ViewControllerRedisplay {
				get {
					const string __id = "VIEW_CONTROLLER_REDISPLAY.Lcom/datadog/android/rum/model/ViewEvent$LoadingType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.LoadingType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.LoadingType.Companion']"
			[global::Android.Runtime.Register ("com/datadog/android/rum/model/ViewEvent$LoadingType$Companion", DoNotGenerateAcw=true)]
			public sealed partial class Companion : global::Java.Lang.Object {
				static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ViewEvent$LoadingType$Companion", typeof (Companion));

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

				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.LoadingType.Companion']/constructor[@name='ViewEvent.LoadingType.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
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

				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.LoadingType.Companion']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ViewEvent$LoadingType;", "")]
				public unsafe global::Com.Datadog.Android.Rum.Model.ViewEvent.LoadingType FromJson (string serializedObject)
				{
					const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ViewEvent$LoadingType;";
					IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_serializedObject);
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.LoadingType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
						JNIEnv.DeleteLocalRef (native_serializedObject);
					}
				}

			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ViewEvent$LoadingType", typeof (LoadingType));

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

			internal LoadingType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.LoadingType']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ViewEvent$LoadingType;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ViewEvent.LoadingType FromJson (string serializedObject)
			{
				const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ViewEvent$LoadingType;";
				IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_serializedObject);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.LoadingType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_serializedObject);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.LoadingType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ViewEvent$LoadingType;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ViewEvent.LoadingType ValueOf (string p0)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ViewEvent$LoadingType;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.LoadingType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.LoadingType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/datadog/android/rum/model/ViewEvent$LoadingType;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ViewEvent.LoadingType[] Values ()
			{
				const string __id = "values.()[Lcom/datadog/android/rum/model/ViewEvent$LoadingType;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Datadog.Android.Rum.Model.ViewEvent.LoadingType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Datadog.Android.Rum.Model.ViewEvent.LoadingType));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.LongTask']"
		[global::Android.Runtime.Register ("com/datadog/android/rum/model/ViewEvent$LongTask", DoNotGenerateAcw=true)]
		public sealed partial class LongTask : global::Java.Lang.Object {
			// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.LongTask.Companion']"
			[global::Android.Runtime.Register ("com/datadog/android/rum/model/ViewEvent$LongTask$Companion", DoNotGenerateAcw=true)]
			public sealed partial class Companion : global::Java.Lang.Object {
				static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ViewEvent$LongTask$Companion", typeof (Companion));

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

				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.LongTask.Companion']/constructor[@name='ViewEvent.LongTask.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
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

				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.LongTask.Companion']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ViewEvent$LongTask;", "")]
				public unsafe global::Com.Datadog.Android.Rum.Model.ViewEvent.LongTask FromJson (string serializedObject)
				{
					const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ViewEvent$LongTask;";
					IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_serializedObject);
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.LongTask> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
						JNIEnv.DeleteLocalRef (native_serializedObject);
					}
				}

			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ViewEvent$LongTask", typeof (LongTask));

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

			internal LongTask (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.LongTask']/constructor[@name='ViewEvent.LongTask' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register (".ctor", "(J)V", "")]
			public unsafe LongTask (long count) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(J)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (count);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			public unsafe long Count {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.LongTask']/method[@name='getCount' and count(parameter)=0]"
				[Register ("getCount", "()J", "")]
				get {
					const string __id = "getCount.()J";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualInt64Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.LongTask']/method[@name='component1' and count(parameter)=0]"
			[Register ("component1", "()J", "")]
			public unsafe long Component1 ()
			{
				const string __id = "component1.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.LongTask']/method[@name='copy' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("copy", "(J)Lcom/datadog/android/rum/model/ViewEvent$LongTask;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ViewEvent.LongTask Copy (long count)
			{
				const string __id = "copy.(J)Lcom/datadog/android/rum/model/ViewEvent$LongTask;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (count);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.LongTask> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.LongTask']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ViewEvent$LongTask;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ViewEvent.LongTask FromJson (string serializedObject)
			{
				const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ViewEvent$LongTask;";
				IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_serializedObject);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.LongTask> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_serializedObject);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Resource']"
		[global::Android.Runtime.Register ("com/datadog/android/rum/model/ViewEvent$Resource", DoNotGenerateAcw=true)]
		public sealed partial class Resource : global::Java.Lang.Object {
			// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Resource.Companion']"
			[global::Android.Runtime.Register ("com/datadog/android/rum/model/ViewEvent$Resource$Companion", DoNotGenerateAcw=true)]
			public sealed partial class Companion : global::Java.Lang.Object {
				static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ViewEvent$Resource$Companion", typeof (Companion));

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

				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Resource.Companion']/constructor[@name='ViewEvent.Resource.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
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

				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Resource.Companion']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ViewEvent$Resource;", "")]
				public unsafe global::Com.Datadog.Android.Rum.Model.ViewEvent.Resource FromJson (string serializedObject)
				{
					const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ViewEvent$Resource;";
					IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_serializedObject);
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.Resource> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
						JNIEnv.DeleteLocalRef (native_serializedObject);
					}
				}

			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ViewEvent$Resource", typeof (Resource));

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

			internal Resource (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Resource']/constructor[@name='ViewEvent.Resource' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register (".ctor", "(J)V", "")]
			public unsafe Resource (long count) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(J)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (count);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			public unsafe long Count {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Resource']/method[@name='getCount' and count(parameter)=0]"
				[Register ("getCount", "()J", "")]
				get {
					const string __id = "getCount.()J";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualInt64Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Resource']/method[@name='component1' and count(parameter)=0]"
			[Register ("component1", "()J", "")]
			public unsafe long Component1 ()
			{
				const string __id = "component1.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Resource']/method[@name='copy' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("copy", "(J)Lcom/datadog/android/rum/model/ViewEvent$Resource;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ViewEvent.Resource Copy (long count)
			{
				const string __id = "copy.(J)Lcom/datadog/android/rum/model/ViewEvent$Resource;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (count);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.Resource> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Resource']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ViewEvent$Resource;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ViewEvent.Resource FromJson (string serializedObject)
			{
				const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ViewEvent$Resource;";
				IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_serializedObject);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.Resource> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_serializedObject);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Session']"
		[global::Android.Runtime.Register ("com/datadog/android/rum/model/ViewEvent$Session", DoNotGenerateAcw=true)]
		public sealed partial class Session : global::Java.Lang.Object {
			// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Session.Companion']"
			[global::Android.Runtime.Register ("com/datadog/android/rum/model/ViewEvent$Session$Companion", DoNotGenerateAcw=true)]
			public sealed partial class Companion : global::Java.Lang.Object {
				static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ViewEvent$Session$Companion", typeof (Companion));

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

				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Session.Companion']/constructor[@name='ViewEvent.Session.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
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

				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Session.Companion']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ViewEvent$Session;", "")]
				public unsafe global::Com.Datadog.Android.Rum.Model.ViewEvent.Session FromJson (string serializedObject)
				{
					const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ViewEvent$Session;";
					IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_serializedObject);
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.Session> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
						JNIEnv.DeleteLocalRef (native_serializedObject);
					}
				}

			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ViewEvent$Session", typeof (Session));

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

			internal Session (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Session']/constructor[@name='ViewEvent.Session' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.datadog.android.rum.model.ViewEvent.Type'] and parameter[3][@type='java.lang.Boolean']]"
			[Register (".ctor", "(Ljava/lang/String;Lcom/datadog/android/rum/model/ViewEvent$Type;Ljava/lang/Boolean;)V", "")]
			public unsafe Session (string id, global::Com.Datadog.Android.Rum.Model.ViewEvent.Type type, global::Java.Lang.Boolean hasReplay) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/String;Lcom/datadog/android/rum/model/ViewEvent$Type;Ljava/lang/Boolean;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_id = JNIEnv.NewString (id);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (native_id);
					__args [1] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
					__args [2] = new JniArgumentValue ((hasReplay == null) ? IntPtr.Zero : ((global::Java.Lang.Object) hasReplay).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_id);
					global::System.GC.KeepAlive (type);
					global::System.GC.KeepAlive (hasReplay);
				}
			}

			public unsafe global::Java.Lang.Boolean HasReplay {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Session']/method[@name='getHasReplay' and count(parameter)=0]"
				[Register ("getHasReplay", "()Ljava/lang/Boolean;", "")]
				get {
					const string __id = "getHasReplay.()Ljava/lang/Boolean;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe string Id {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Session']/method[@name='getId' and count(parameter)=0]"
				[Register ("getId", "()Ljava/lang/String;", "")]
				get {
					const string __id = "getId.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe global::Com.Datadog.Android.Rum.Model.ViewEvent.Type Type {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Session']/method[@name='getType' and count(parameter)=0]"
				[Register ("getType", "()Lcom/datadog/android/rum/model/ViewEvent$Type;", "")]
				get {
					const string __id = "getType.()Lcom/datadog/android/rum/model/ViewEvent$Type;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.Type> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Session']/method[@name='component1' and count(parameter)=0]"
			[Register ("component1", "()Ljava/lang/String;", "")]
			public unsafe string Component1 ()
			{
				const string __id = "component1.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Session']/method[@name='component2' and count(parameter)=0]"
			[Register ("component2", "()Lcom/datadog/android/rum/model/ViewEvent$Type;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ViewEvent.Type Component2 ()
			{
				const string __id = "component2.()Lcom/datadog/android/rum/model/ViewEvent$Type;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.Type> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Session']/method[@name='component3' and count(parameter)=0]"
			[Register ("component3", "()Ljava/lang/Boolean;", "")]
			public unsafe global::Java.Lang.Boolean Component3 ()
			{
				const string __id = "component3.()Ljava/lang/Boolean;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Session']/method[@name='copy' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.datadog.android.rum.model.ViewEvent.Type'] and parameter[3][@type='java.lang.Boolean']]"
			[Register ("copy", "(Ljava/lang/String;Lcom/datadog/android/rum/model/ViewEvent$Type;Ljava/lang/Boolean;)Lcom/datadog/android/rum/model/ViewEvent$Session;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ViewEvent.Session Copy (string id, global::Com.Datadog.Android.Rum.Model.ViewEvent.Type type, global::Java.Lang.Boolean hasReplay)
			{
				const string __id = "copy.(Ljava/lang/String;Lcom/datadog/android/rum/model/ViewEvent$Type;Ljava/lang/Boolean;)Lcom/datadog/android/rum/model/ViewEvent$Session;";
				IntPtr native_id = JNIEnv.NewString (id);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (native_id);
					__args [1] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
					__args [2] = new JniArgumentValue ((hasReplay == null) ? IntPtr.Zero : ((global::Java.Lang.Object) hasReplay).Handle);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.Session> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_id);
					global::System.GC.KeepAlive (type);
					global::System.GC.KeepAlive (hasReplay);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Session']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ViewEvent$Session;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ViewEvent.Session FromJson (string serializedObject)
			{
				const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ViewEvent$Session;";
				IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_serializedObject);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.Session> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_serializedObject);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Status']"
		[global::Android.Runtime.Register ("com/datadog/android/rum/model/ViewEvent$Status", DoNotGenerateAcw=true)]
		public sealed partial class Status : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Status']/field[@name='CONNECTED']"
			[Register ("CONNECTED")]
			public static global::Com.Datadog.Android.Rum.Model.ViewEvent.Status Connected {
				get {
					const string __id = "CONNECTED.Lcom/datadog/android/rum/model/ViewEvent$Status;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.Status> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Status']/field[@name='MAYBE']"
			[Register ("MAYBE")]
			public static global::Com.Datadog.Android.Rum.Model.ViewEvent.Status Maybe {
				get {
					const string __id = "MAYBE.Lcom/datadog/android/rum/model/ViewEvent$Status;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.Status> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Status']/field[@name='NOT_CONNECTED']"
			[Register ("NOT_CONNECTED")]
			public static global::Com.Datadog.Android.Rum.Model.ViewEvent.Status NotConnected {
				get {
					const string __id = "NOT_CONNECTED.Lcom/datadog/android/rum/model/ViewEvent$Status;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.Status> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Status.Companion']"
			[global::Android.Runtime.Register ("com/datadog/android/rum/model/ViewEvent$Status$Companion", DoNotGenerateAcw=true)]
			public sealed partial class Companion : global::Java.Lang.Object {
				static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ViewEvent$Status$Companion", typeof (Companion));

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

				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Status.Companion']/constructor[@name='ViewEvent.Status.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
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

				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Status.Companion']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ViewEvent$Status;", "")]
				public unsafe global::Com.Datadog.Android.Rum.Model.ViewEvent.Status FromJson (string serializedObject)
				{
					const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ViewEvent$Status;";
					IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_serializedObject);
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.Status> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
						JNIEnv.DeleteLocalRef (native_serializedObject);
					}
				}

			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ViewEvent$Status", typeof (Status));

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

			internal Status (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Status']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ViewEvent$Status;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ViewEvent.Status FromJson (string serializedObject)
			{
				const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ViewEvent$Status;";
				IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_serializedObject);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.Status> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_serializedObject);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Status']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ViewEvent$Status;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ViewEvent.Status ValueOf (string p0)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ViewEvent$Status;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.Status> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Status']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/datadog/android/rum/model/ViewEvent$Status;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ViewEvent.Status[] Values ()
			{
				const string __id = "values.()[Lcom/datadog/android/rum/model/ViewEvent$Status;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Datadog.Android.Rum.Model.ViewEvent.Status[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Datadog.Android.Rum.Model.ViewEvent.Status));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Type']"
		[global::Android.Runtime.Register ("com/datadog/android/rum/model/ViewEvent$Type", DoNotGenerateAcw=true)]
		public sealed partial class Type : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Type']/field[@name='SYNTHETICS']"
			[Register ("SYNTHETICS")]
			public static global::Com.Datadog.Android.Rum.Model.ViewEvent.Type Synthetics {
				get {
					const string __id = "SYNTHETICS.Lcom/datadog/android/rum/model/ViewEvent$Type;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.Type> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Type']/field[@name='USER']"
			[Register ("USER")]
			public static global::Com.Datadog.Android.Rum.Model.ViewEvent.Type User {
				get {
					const string __id = "USER.Lcom/datadog/android/rum/model/ViewEvent$Type;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.Type> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Type.Companion']"
			[global::Android.Runtime.Register ("com/datadog/android/rum/model/ViewEvent$Type$Companion", DoNotGenerateAcw=true)]
			public sealed partial class Companion : global::Java.Lang.Object {
				static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ViewEvent$Type$Companion", typeof (Companion));

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

				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Type.Companion']/constructor[@name='ViewEvent.Type.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
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

				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Type.Companion']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ViewEvent$Type;", "")]
				public unsafe global::Com.Datadog.Android.Rum.Model.ViewEvent.Type FromJson (string serializedObject)
				{
					const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ViewEvent$Type;";
					IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_serializedObject);
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.Type> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
						JNIEnv.DeleteLocalRef (native_serializedObject);
					}
				}

			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ViewEvent$Type", typeof (Type));

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

			internal Type (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Type']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ViewEvent$Type;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ViewEvent.Type FromJson (string serializedObject)
			{
				const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ViewEvent$Type;";
				IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_serializedObject);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.Type> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_serializedObject);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Type']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ViewEvent$Type;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ViewEvent.Type ValueOf (string p0)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ViewEvent$Type;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.Type> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Type']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/datadog/android/rum/model/ViewEvent$Type;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ViewEvent.Type[] Values ()
			{
				const string __id = "values.()[Lcom/datadog/android/rum/model/ViewEvent$Type;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Datadog.Android.Rum.Model.ViewEvent.Type[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Datadog.Android.Rum.Model.ViewEvent.Type));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Usr']"
		[global::Android.Runtime.Register ("com/datadog/android/rum/model/ViewEvent$Usr", DoNotGenerateAcw=true)]
		public sealed partial class Usr : global::Java.Lang.Object {
			// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Usr.Companion']"
			[global::Android.Runtime.Register ("com/datadog/android/rum/model/ViewEvent$Usr$Companion", DoNotGenerateAcw=true)]
			public sealed partial class Companion : global::Java.Lang.Object {
				static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ViewEvent$Usr$Companion", typeof (Companion));

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

				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Usr.Companion']/constructor[@name='ViewEvent.Usr.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
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

				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Usr.Companion']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ViewEvent$Usr;", "")]
				public unsafe global::Com.Datadog.Android.Rum.Model.ViewEvent.Usr FromJson (string serializedObject)
				{
					const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ViewEvent$Usr;";
					IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_serializedObject);
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.Usr> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
						JNIEnv.DeleteLocalRef (native_serializedObject);
					}
				}

			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ViewEvent$Usr", typeof (Usr));

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

			internal Usr (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Usr']/constructor[@name='ViewEvent.Usr' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Usr () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Usr']/constructor[@name='ViewEvent.Usr' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
			[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
			public unsafe Usr (string id, string name, string email) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_id = JNIEnv.NewString (id);
				IntPtr native_name = JNIEnv.NewString (name);
				IntPtr native_email = JNIEnv.NewString (email);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (native_id);
					__args [1] = new JniArgumentValue (native_name);
					__args [2] = new JniArgumentValue (native_email);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_id);
					JNIEnv.DeleteLocalRef (native_name);
					JNIEnv.DeleteLocalRef (native_email);
				}
			}

			public unsafe string Email {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Usr']/method[@name='getEmail' and count(parameter)=0]"
				[Register ("getEmail", "()Ljava/lang/String;", "")]
				get {
					const string __id = "getEmail.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe string Id {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Usr']/method[@name='getId' and count(parameter)=0]"
				[Register ("getId", "()Ljava/lang/String;", "")]
				get {
					const string __id = "getId.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe string Name {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Usr']/method[@name='getName' and count(parameter)=0]"
				[Register ("getName", "()Ljava/lang/String;", "")]
				get {
					const string __id = "getName.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Usr']/method[@name='component1' and count(parameter)=0]"
			[Register ("component1", "()Ljava/lang/String;", "")]
			public unsafe string Component1 ()
			{
				const string __id = "component1.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Usr']/method[@name='component2' and count(parameter)=0]"
			[Register ("component2", "()Ljava/lang/String;", "")]
			public unsafe string Component2 ()
			{
				const string __id = "component2.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Usr']/method[@name='component3' and count(parameter)=0]"
			[Register ("component3", "()Ljava/lang/String;", "")]
			public unsafe string Component3 ()
			{
				const string __id = "component3.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Usr']/method[@name='copy' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
			[Register ("copy", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/datadog/android/rum/model/ViewEvent$Usr;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ViewEvent.Usr Copy (string id, string name, string email)
			{
				const string __id = "copy.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/datadog/android/rum/model/ViewEvent$Usr;";
				IntPtr native_id = JNIEnv.NewString (id);
				IntPtr native_name = JNIEnv.NewString (name);
				IntPtr native_email = JNIEnv.NewString (email);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (native_id);
					__args [1] = new JniArgumentValue (native_name);
					__args [2] = new JniArgumentValue (native_email);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.Usr> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_id);
					JNIEnv.DeleteLocalRef (native_name);
					JNIEnv.DeleteLocalRef (native_email);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.Usr']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ViewEvent$Usr;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ViewEvent.Usr FromJson (string serializedObject)
			{
				const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ViewEvent$Usr;";
				IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_serializedObject);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.Usr> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_serializedObject);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.View']"
		[global::Android.Runtime.Register ("com/datadog/android/rum/model/ViewEvent$View", DoNotGenerateAcw=true)]
		public sealed partial class View : global::Java.Lang.Object {
			// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.View.Companion']"
			[global::Android.Runtime.Register ("com/datadog/android/rum/model/ViewEvent$View$Companion", DoNotGenerateAcw=true)]
			public sealed partial class Companion : global::Java.Lang.Object {
				static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ViewEvent$View$Companion", typeof (Companion));

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

				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.View.Companion']/constructor[@name='ViewEvent.View.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
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

				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.View.Companion']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ViewEvent$View;", "")]
				public unsafe global::Com.Datadog.Android.Rum.Model.ViewEvent.View FromJson (string serializedObject)
				{
					const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ViewEvent$View;";
					IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_serializedObject);
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.View> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
						JNIEnv.DeleteLocalRef (native_serializedObject);
					}
				}

			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ViewEvent$View", typeof (View));

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

			internal View (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.View']/constructor[@name='ViewEvent.View' and count(parameter)=22 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Long'] and parameter[5][@type='com.datadog.android.rum.model.ViewEvent.LoadingType'] and parameter[6][@type='long'] and parameter[7][@type='java.lang.Long'] and parameter[8][@type='java.lang.Long'] and parameter[9][@type='java.lang.Long'] and parameter[10][@type='java.lang.Long'] and parameter[11][@type='java.lang.Double'] and parameter[12][@type='java.lang.Long'] and parameter[13][@type='java.lang.Long'] and parameter[14][@type='java.lang.Long'] and parameter[15][@type='java.lang.Long'] and parameter[16][@type='com.datadog.android.rum.model.ViewEvent.CustomTimings'] and parameter[17][@type='java.lang.Boolean'] and parameter[18][@type='com.datadog.android.rum.model.ViewEvent.Action'] and parameter[19][@type='com.datadog.android.rum.model.ViewEvent.Error'] and parameter[20][@type='com.datadog.android.rum.model.ViewEvent.Crash'] and parameter[21][@type='com.datadog.android.rum.model.ViewEvent.LongTask'] and parameter[22][@type='com.datadog.android.rum.model.ViewEvent.Resource']]"
			[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Long;Lcom/datadog/android/rum/model/ViewEvent$LoadingType;JLjava/lang/Long;Ljava/lang/Long;Ljava/lang/Long;Ljava/lang/Long;Ljava/lang/Double;Ljava/lang/Long;Ljava/lang/Long;Ljava/lang/Long;Ljava/lang/Long;Lcom/datadog/android/rum/model/ViewEvent$CustomTimings;Ljava/lang/Boolean;Lcom/datadog/android/rum/model/ViewEvent$Action;Lcom/datadog/android/rum/model/ViewEvent$Error;Lcom/datadog/android/rum/model/ViewEvent$Crash;Lcom/datadog/android/rum/model/ViewEvent$LongTask;Lcom/datadog/android/rum/model/ViewEvent$Resource;)V", "")]
			public unsafe View (string id, string referrer, string url, global::Java.Lang.Long loadingTime, global::Com.Datadog.Android.Rum.Model.ViewEvent.LoadingType loadingType, long timeSpent, global::Java.Lang.Long firstContentfulPaint, global::Java.Lang.Long largestContentfulPaint, global::Java.Lang.Long firstInputDelay, global::Java.Lang.Long firstInputTime, global::Java.Lang.Double cumulativeLayoutShift, global::Java.Lang.Long domComplete, global::Java.Lang.Long domContentLoaded, global::Java.Lang.Long domInteractive, global::Java.Lang.Long loadEvent, global::Com.Datadog.Android.Rum.Model.ViewEvent.CustomTimings customTimings, global::Java.Lang.Boolean isActive, global::Com.Datadog.Android.Rum.Model.ViewEvent.Action action, global::Com.Datadog.Android.Rum.Model.ViewEvent.Error error, global::Com.Datadog.Android.Rum.Model.ViewEvent.Crash crash, global::Com.Datadog.Android.Rum.Model.ViewEvent.LongTask longTask, global::Com.Datadog.Android.Rum.Model.ViewEvent.Resource resource) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Long;Lcom/datadog/android/rum/model/ViewEvent$LoadingType;JLjava/lang/Long;Ljava/lang/Long;Ljava/lang/Long;Ljava/lang/Long;Ljava/lang/Double;Ljava/lang/Long;Ljava/lang/Long;Ljava/lang/Long;Ljava/lang/Long;Lcom/datadog/android/rum/model/ViewEvent$CustomTimings;Ljava/lang/Boolean;Lcom/datadog/android/rum/model/ViewEvent$Action;Lcom/datadog/android/rum/model/ViewEvent$Error;Lcom/datadog/android/rum/model/ViewEvent$Crash;Lcom/datadog/android/rum/model/ViewEvent$LongTask;Lcom/datadog/android/rum/model/ViewEvent$Resource;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_id = JNIEnv.NewString (id);
				IntPtr native_referrer = JNIEnv.NewString (referrer);
				IntPtr native_url = JNIEnv.NewString (url);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [22];
					__args [0] = new JniArgumentValue (native_id);
					__args [1] = new JniArgumentValue (native_referrer);
					__args [2] = new JniArgumentValue (native_url);
					__args [3] = new JniArgumentValue ((loadingTime == null) ? IntPtr.Zero : ((global::Java.Lang.Object) loadingTime).Handle);
					__args [4] = new JniArgumentValue ((loadingType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) loadingType).Handle);
					__args [5] = new JniArgumentValue (timeSpent);
					__args [6] = new JniArgumentValue ((firstContentfulPaint == null) ? IntPtr.Zero : ((global::Java.Lang.Object) firstContentfulPaint).Handle);
					__args [7] = new JniArgumentValue ((largestContentfulPaint == null) ? IntPtr.Zero : ((global::Java.Lang.Object) largestContentfulPaint).Handle);
					__args [8] = new JniArgumentValue ((firstInputDelay == null) ? IntPtr.Zero : ((global::Java.Lang.Object) firstInputDelay).Handle);
					__args [9] = new JniArgumentValue ((firstInputTime == null) ? IntPtr.Zero : ((global::Java.Lang.Object) firstInputTime).Handle);
					__args [10] = new JniArgumentValue ((cumulativeLayoutShift == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cumulativeLayoutShift).Handle);
					__args [11] = new JniArgumentValue ((domComplete == null) ? IntPtr.Zero : ((global::Java.Lang.Object) domComplete).Handle);
					__args [12] = new JniArgumentValue ((domContentLoaded == null) ? IntPtr.Zero : ((global::Java.Lang.Object) domContentLoaded).Handle);
					__args [13] = new JniArgumentValue ((domInteractive == null) ? IntPtr.Zero : ((global::Java.Lang.Object) domInteractive).Handle);
					__args [14] = new JniArgumentValue ((loadEvent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) loadEvent).Handle);
					__args [15] = new JniArgumentValue ((customTimings == null) ? IntPtr.Zero : ((global::Java.Lang.Object) customTimings).Handle);
					__args [16] = new JniArgumentValue ((isActive == null) ? IntPtr.Zero : ((global::Java.Lang.Object) isActive).Handle);
					__args [17] = new JniArgumentValue ((action == null) ? IntPtr.Zero : ((global::Java.Lang.Object) action).Handle);
					__args [18] = new JniArgumentValue ((error == null) ? IntPtr.Zero : ((global::Java.Lang.Object) error).Handle);
					__args [19] = new JniArgumentValue ((crash == null) ? IntPtr.Zero : ((global::Java.Lang.Object) crash).Handle);
					__args [20] = new JniArgumentValue ((longTask == null) ? IntPtr.Zero : ((global::Java.Lang.Object) longTask).Handle);
					__args [21] = new JniArgumentValue ((resource == null) ? IntPtr.Zero : ((global::Java.Lang.Object) resource).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_id);
					JNIEnv.DeleteLocalRef (native_referrer);
					JNIEnv.DeleteLocalRef (native_url);
					global::System.GC.KeepAlive (loadingTime);
					global::System.GC.KeepAlive (loadingType);
					global::System.GC.KeepAlive (firstContentfulPaint);
					global::System.GC.KeepAlive (largestContentfulPaint);
					global::System.GC.KeepAlive (firstInputDelay);
					global::System.GC.KeepAlive (firstInputTime);
					global::System.GC.KeepAlive (cumulativeLayoutShift);
					global::System.GC.KeepAlive (domComplete);
					global::System.GC.KeepAlive (domContentLoaded);
					global::System.GC.KeepAlive (domInteractive);
					global::System.GC.KeepAlive (loadEvent);
					global::System.GC.KeepAlive (customTimings);
					global::System.GC.KeepAlive (isActive);
					global::System.GC.KeepAlive (action);
					global::System.GC.KeepAlive (error);
					global::System.GC.KeepAlive (crash);
					global::System.GC.KeepAlive (longTask);
					global::System.GC.KeepAlive (resource);
				}
			}

			public unsafe global::Com.Datadog.Android.Rum.Model.ViewEvent.Action Action {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.View']/method[@name='getAction' and count(parameter)=0]"
				[Register ("getAction", "()Lcom/datadog/android/rum/model/ViewEvent$Action;", "")]
				get {
					const string __id = "getAction.()Lcom/datadog/android/rum/model/ViewEvent$Action;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.Action> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe global::Com.Datadog.Android.Rum.Model.ViewEvent.Crash Crash {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.View']/method[@name='getCrash' and count(parameter)=0]"
				[Register ("getCrash", "()Lcom/datadog/android/rum/model/ViewEvent$Crash;", "")]
				get {
					const string __id = "getCrash.()Lcom/datadog/android/rum/model/ViewEvent$Crash;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.Crash> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe global::Java.Lang.Double CumulativeLayoutShift {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.View']/method[@name='getCumulativeLayoutShift' and count(parameter)=0]"
				[Register ("getCumulativeLayoutShift", "()Ljava/lang/Double;", "")]
				get {
					const string __id = "getCumulativeLayoutShift.()Ljava/lang/Double;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe global::Com.Datadog.Android.Rum.Model.ViewEvent.CustomTimings CustomTimings {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.View']/method[@name='getCustomTimings' and count(parameter)=0]"
				[Register ("getCustomTimings", "()Lcom/datadog/android/rum/model/ViewEvent$CustomTimings;", "")]
				get {
					const string __id = "getCustomTimings.()Lcom/datadog/android/rum/model/ViewEvent$CustomTimings;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.CustomTimings> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe global::Java.Lang.Long DomComplete {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.View']/method[@name='getDomComplete' and count(parameter)=0]"
				[Register ("getDomComplete", "()Ljava/lang/Long;", "")]
				get {
					const string __id = "getDomComplete.()Ljava/lang/Long;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe global::Java.Lang.Long DomContentLoaded {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.View']/method[@name='getDomContentLoaded' and count(parameter)=0]"
				[Register ("getDomContentLoaded", "()Ljava/lang/Long;", "")]
				get {
					const string __id = "getDomContentLoaded.()Ljava/lang/Long;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe global::Java.Lang.Long DomInteractive {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.View']/method[@name='getDomInteractive' and count(parameter)=0]"
				[Register ("getDomInteractive", "()Ljava/lang/Long;", "")]
				get {
					const string __id = "getDomInteractive.()Ljava/lang/Long;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe global::Com.Datadog.Android.Rum.Model.ViewEvent.Error Error {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.View']/method[@name='getError' and count(parameter)=0]"
				[Register ("getError", "()Lcom/datadog/android/rum/model/ViewEvent$Error;", "")]
				get {
					const string __id = "getError.()Lcom/datadog/android/rum/model/ViewEvent$Error;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.Error> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe global::Java.Lang.Long FirstContentfulPaint {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.View']/method[@name='getFirstContentfulPaint' and count(parameter)=0]"
				[Register ("getFirstContentfulPaint", "()Ljava/lang/Long;", "")]
				get {
					const string __id = "getFirstContentfulPaint.()Ljava/lang/Long;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe global::Java.Lang.Long FirstInputDelay {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.View']/method[@name='getFirstInputDelay' and count(parameter)=0]"
				[Register ("getFirstInputDelay", "()Ljava/lang/Long;", "")]
				get {
					const string __id = "getFirstInputDelay.()Ljava/lang/Long;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe global::Java.Lang.Long FirstInputTime {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.View']/method[@name='getFirstInputTime' and count(parameter)=0]"
				[Register ("getFirstInputTime", "()Ljava/lang/Long;", "")]
				get {
					const string __id = "getFirstInputTime.()Ljava/lang/Long;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe string Id {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.View']/method[@name='getId' and count(parameter)=0]"
				[Register ("getId", "()Ljava/lang/String;", "")]
				get {
					const string __id = "getId.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe global::Java.Lang.Long LargestContentfulPaint {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.View']/method[@name='getLargestContentfulPaint' and count(parameter)=0]"
				[Register ("getLargestContentfulPaint", "()Ljava/lang/Long;", "")]
				get {
					const string __id = "getLargestContentfulPaint.()Ljava/lang/Long;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe global::Java.Lang.Long LoadEvent {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.View']/method[@name='getLoadEvent' and count(parameter)=0]"
				[Register ("getLoadEvent", "()Ljava/lang/Long;", "")]
				get {
					const string __id = "getLoadEvent.()Ljava/lang/Long;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe global::Java.Lang.Long LoadingTime {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.View']/method[@name='getLoadingTime' and count(parameter)=0]"
				[Register ("getLoadingTime", "()Ljava/lang/Long;", "")]
				get {
					const string __id = "getLoadingTime.()Ljava/lang/Long;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe global::Com.Datadog.Android.Rum.Model.ViewEvent.LoadingType LoadingType {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.View']/method[@name='getLoadingType' and count(parameter)=0]"
				[Register ("getLoadingType", "()Lcom/datadog/android/rum/model/ViewEvent$LoadingType;", "")]
				get {
					const string __id = "getLoadingType.()Lcom/datadog/android/rum/model/ViewEvent$LoadingType;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.LoadingType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe global::Com.Datadog.Android.Rum.Model.ViewEvent.LongTask LongTask {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.View']/method[@name='getLongTask' and count(parameter)=0]"
				[Register ("getLongTask", "()Lcom/datadog/android/rum/model/ViewEvent$LongTask;", "")]
				get {
					const string __id = "getLongTask.()Lcom/datadog/android/rum/model/ViewEvent$LongTask;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.LongTask> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe string Referrer {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.View']/method[@name='getReferrer' and count(parameter)=0]"
				[Register ("getReferrer", "()Ljava/lang/String;", "")]
				get {
					const string __id = "getReferrer.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.View']/method[@name='setReferrer' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setReferrer", "(Ljava/lang/String;)V", "")]
				set {
					const string __id = "setReferrer.(Ljava/lang/String;)V";
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_value);
						_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			public unsafe global::Com.Datadog.Android.Rum.Model.ViewEvent.Resource Resource {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.View']/method[@name='getResource' and count(parameter)=0]"
				[Register ("getResource", "()Lcom/datadog/android/rum/model/ViewEvent$Resource;", "")]
				get {
					const string __id = "getResource.()Lcom/datadog/android/rum/model/ViewEvent$Resource;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.Resource> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe long TimeSpent {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.View']/method[@name='getTimeSpent' and count(parameter)=0]"
				[Register ("getTimeSpent", "()J", "")]
				get {
					const string __id = "getTimeSpent.()J";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualInt64Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			public unsafe string Url {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.View']/method[@name='getUrl' and count(parameter)=0]"
				[Register ("getUrl", "()Ljava/lang/String;", "")]
				get {
					const string __id = "getUrl.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.View']/method[@name='setUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setUrl", "(Ljava/lang/String;)V", "")]
				set {
					const string __id = "setUrl.(Ljava/lang/String;)V";
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_value);
						_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.View']/method[@name='component1' and count(parameter)=0]"
			[Register ("component1", "()Ljava/lang/String;", "")]
			public unsafe string Component1 ()
			{
				const string __id = "component1.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.View']/method[@name='component10' and count(parameter)=0]"
			[Register ("component10", "()Ljava/lang/Long;", "")]
			public unsafe global::Java.Lang.Long Component10 ()
			{
				const string __id = "component10.()Ljava/lang/Long;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.View']/method[@name='component11' and count(parameter)=0]"
			[Register ("component11", "()Ljava/lang/Double;", "")]
			public unsafe global::Java.Lang.Double Component11 ()
			{
				const string __id = "component11.()Ljava/lang/Double;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.View']/method[@name='component12' and count(parameter)=0]"
			[Register ("component12", "()Ljava/lang/Long;", "")]
			public unsafe global::Java.Lang.Long Component12 ()
			{
				const string __id = "component12.()Ljava/lang/Long;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.View']/method[@name='component13' and count(parameter)=0]"
			[Register ("component13", "()Ljava/lang/Long;", "")]
			public unsafe global::Java.Lang.Long Component13 ()
			{
				const string __id = "component13.()Ljava/lang/Long;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.View']/method[@name='component14' and count(parameter)=0]"
			[Register ("component14", "()Ljava/lang/Long;", "")]
			public unsafe global::Java.Lang.Long Component14 ()
			{
				const string __id = "component14.()Ljava/lang/Long;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.View']/method[@name='component15' and count(parameter)=0]"
			[Register ("component15", "()Ljava/lang/Long;", "")]
			public unsafe global::Java.Lang.Long Component15 ()
			{
				const string __id = "component15.()Ljava/lang/Long;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.View']/method[@name='component16' and count(parameter)=0]"
			[Register ("component16", "()Lcom/datadog/android/rum/model/ViewEvent$CustomTimings;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ViewEvent.CustomTimings Component16 ()
			{
				const string __id = "component16.()Lcom/datadog/android/rum/model/ViewEvent$CustomTimings;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.CustomTimings> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.View']/method[@name='component17' and count(parameter)=0]"
			[Register ("component17", "()Ljava/lang/Boolean;", "")]
			public unsafe global::Java.Lang.Boolean Component17 ()
			{
				const string __id = "component17.()Ljava/lang/Boolean;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.View']/method[@name='component18' and count(parameter)=0]"
			[Register ("component18", "()Lcom/datadog/android/rum/model/ViewEvent$Action;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ViewEvent.Action Component18 ()
			{
				const string __id = "component18.()Lcom/datadog/android/rum/model/ViewEvent$Action;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.Action> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.View']/method[@name='component19' and count(parameter)=0]"
			[Register ("component19", "()Lcom/datadog/android/rum/model/ViewEvent$Error;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ViewEvent.Error Component19 ()
			{
				const string __id = "component19.()Lcom/datadog/android/rum/model/ViewEvent$Error;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.Error> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.View']/method[@name='component2' and count(parameter)=0]"
			[Register ("component2", "()Ljava/lang/String;", "")]
			public unsafe string Component2 ()
			{
				const string __id = "component2.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.View']/method[@name='component20' and count(parameter)=0]"
			[Register ("component20", "()Lcom/datadog/android/rum/model/ViewEvent$Crash;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ViewEvent.Crash Component20 ()
			{
				const string __id = "component20.()Lcom/datadog/android/rum/model/ViewEvent$Crash;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.Crash> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.View']/method[@name='component21' and count(parameter)=0]"
			[Register ("component21", "()Lcom/datadog/android/rum/model/ViewEvent$LongTask;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ViewEvent.LongTask Component21 ()
			{
				const string __id = "component21.()Lcom/datadog/android/rum/model/ViewEvent$LongTask;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.LongTask> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.View']/method[@name='component22' and count(parameter)=0]"
			[Register ("component22", "()Lcom/datadog/android/rum/model/ViewEvent$Resource;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ViewEvent.Resource Component22 ()
			{
				const string __id = "component22.()Lcom/datadog/android/rum/model/ViewEvent$Resource;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.Resource> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.View']/method[@name='component3' and count(parameter)=0]"
			[Register ("component3", "()Ljava/lang/String;", "")]
			public unsafe string Component3 ()
			{
				const string __id = "component3.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.View']/method[@name='component4' and count(parameter)=0]"
			[Register ("component4", "()Ljava/lang/Long;", "")]
			public unsafe global::Java.Lang.Long Component4 ()
			{
				const string __id = "component4.()Ljava/lang/Long;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.View']/method[@name='component5' and count(parameter)=0]"
			[Register ("component5", "()Lcom/datadog/android/rum/model/ViewEvent$LoadingType;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ViewEvent.LoadingType Component5 ()
			{
				const string __id = "component5.()Lcom/datadog/android/rum/model/ViewEvent$LoadingType;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.LoadingType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.View']/method[@name='component6' and count(parameter)=0]"
			[Register ("component6", "()J", "")]
			public unsafe long Component6 ()
			{
				const string __id = "component6.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.View']/method[@name='component7' and count(parameter)=0]"
			[Register ("component7", "()Ljava/lang/Long;", "")]
			public unsafe global::Java.Lang.Long Component7 ()
			{
				const string __id = "component7.()Ljava/lang/Long;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.View']/method[@name='component8' and count(parameter)=0]"
			[Register ("component8", "()Ljava/lang/Long;", "")]
			public unsafe global::Java.Lang.Long Component8 ()
			{
				const string __id = "component8.()Ljava/lang/Long;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.View']/method[@name='component9' and count(parameter)=0]"
			[Register ("component9", "()Ljava/lang/Long;", "")]
			public unsafe global::Java.Lang.Long Component9 ()
			{
				const string __id = "component9.()Ljava/lang/Long;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.View']/method[@name='copy' and count(parameter)=22 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Long'] and parameter[5][@type='com.datadog.android.rum.model.ViewEvent.LoadingType'] and parameter[6][@type='long'] and parameter[7][@type='java.lang.Long'] and parameter[8][@type='java.lang.Long'] and parameter[9][@type='java.lang.Long'] and parameter[10][@type='java.lang.Long'] and parameter[11][@type='java.lang.Double'] and parameter[12][@type='java.lang.Long'] and parameter[13][@type='java.lang.Long'] and parameter[14][@type='java.lang.Long'] and parameter[15][@type='java.lang.Long'] and parameter[16][@type='com.datadog.android.rum.model.ViewEvent.CustomTimings'] and parameter[17][@type='java.lang.Boolean'] and parameter[18][@type='com.datadog.android.rum.model.ViewEvent.Action'] and parameter[19][@type='com.datadog.android.rum.model.ViewEvent.Error'] and parameter[20][@type='com.datadog.android.rum.model.ViewEvent.Crash'] and parameter[21][@type='com.datadog.android.rum.model.ViewEvent.LongTask'] and parameter[22][@type='com.datadog.android.rum.model.ViewEvent.Resource']]"
			[Register ("copy", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Long;Lcom/datadog/android/rum/model/ViewEvent$LoadingType;JLjava/lang/Long;Ljava/lang/Long;Ljava/lang/Long;Ljava/lang/Long;Ljava/lang/Double;Ljava/lang/Long;Ljava/lang/Long;Ljava/lang/Long;Ljava/lang/Long;Lcom/datadog/android/rum/model/ViewEvent$CustomTimings;Ljava/lang/Boolean;Lcom/datadog/android/rum/model/ViewEvent$Action;Lcom/datadog/android/rum/model/ViewEvent$Error;Lcom/datadog/android/rum/model/ViewEvent$Crash;Lcom/datadog/android/rum/model/ViewEvent$LongTask;Lcom/datadog/android/rum/model/ViewEvent$Resource;)Lcom/datadog/android/rum/model/ViewEvent$View;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ViewEvent.View Copy (string id, string referrer, string url, global::Java.Lang.Long loadingTime, global::Com.Datadog.Android.Rum.Model.ViewEvent.LoadingType loadingType, long timeSpent, global::Java.Lang.Long firstContentfulPaint, global::Java.Lang.Long largestContentfulPaint, global::Java.Lang.Long firstInputDelay, global::Java.Lang.Long firstInputTime, global::Java.Lang.Double cumulativeLayoutShift, global::Java.Lang.Long domComplete, global::Java.Lang.Long domContentLoaded, global::Java.Lang.Long domInteractive, global::Java.Lang.Long loadEvent, global::Com.Datadog.Android.Rum.Model.ViewEvent.CustomTimings customTimings, global::Java.Lang.Boolean isActive, global::Com.Datadog.Android.Rum.Model.ViewEvent.Action action, global::Com.Datadog.Android.Rum.Model.ViewEvent.Error error, global::Com.Datadog.Android.Rum.Model.ViewEvent.Crash crash, global::Com.Datadog.Android.Rum.Model.ViewEvent.LongTask longTask, global::Com.Datadog.Android.Rum.Model.ViewEvent.Resource resource)
			{
				const string __id = "copy.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Long;Lcom/datadog/android/rum/model/ViewEvent$LoadingType;JLjava/lang/Long;Ljava/lang/Long;Ljava/lang/Long;Ljava/lang/Long;Ljava/lang/Double;Ljava/lang/Long;Ljava/lang/Long;Ljava/lang/Long;Ljava/lang/Long;Lcom/datadog/android/rum/model/ViewEvent$CustomTimings;Ljava/lang/Boolean;Lcom/datadog/android/rum/model/ViewEvent$Action;Lcom/datadog/android/rum/model/ViewEvent$Error;Lcom/datadog/android/rum/model/ViewEvent$Crash;Lcom/datadog/android/rum/model/ViewEvent$LongTask;Lcom/datadog/android/rum/model/ViewEvent$Resource;)Lcom/datadog/android/rum/model/ViewEvent$View;";
				IntPtr native_id = JNIEnv.NewString (id);
				IntPtr native_referrer = JNIEnv.NewString (referrer);
				IntPtr native_url = JNIEnv.NewString (url);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [22];
					__args [0] = new JniArgumentValue (native_id);
					__args [1] = new JniArgumentValue (native_referrer);
					__args [2] = new JniArgumentValue (native_url);
					__args [3] = new JniArgumentValue ((loadingTime == null) ? IntPtr.Zero : ((global::Java.Lang.Object) loadingTime).Handle);
					__args [4] = new JniArgumentValue ((loadingType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) loadingType).Handle);
					__args [5] = new JniArgumentValue (timeSpent);
					__args [6] = new JniArgumentValue ((firstContentfulPaint == null) ? IntPtr.Zero : ((global::Java.Lang.Object) firstContentfulPaint).Handle);
					__args [7] = new JniArgumentValue ((largestContentfulPaint == null) ? IntPtr.Zero : ((global::Java.Lang.Object) largestContentfulPaint).Handle);
					__args [8] = new JniArgumentValue ((firstInputDelay == null) ? IntPtr.Zero : ((global::Java.Lang.Object) firstInputDelay).Handle);
					__args [9] = new JniArgumentValue ((firstInputTime == null) ? IntPtr.Zero : ((global::Java.Lang.Object) firstInputTime).Handle);
					__args [10] = new JniArgumentValue ((cumulativeLayoutShift == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cumulativeLayoutShift).Handle);
					__args [11] = new JniArgumentValue ((domComplete == null) ? IntPtr.Zero : ((global::Java.Lang.Object) domComplete).Handle);
					__args [12] = new JniArgumentValue ((domContentLoaded == null) ? IntPtr.Zero : ((global::Java.Lang.Object) domContentLoaded).Handle);
					__args [13] = new JniArgumentValue ((domInteractive == null) ? IntPtr.Zero : ((global::Java.Lang.Object) domInteractive).Handle);
					__args [14] = new JniArgumentValue ((loadEvent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) loadEvent).Handle);
					__args [15] = new JniArgumentValue ((customTimings == null) ? IntPtr.Zero : ((global::Java.Lang.Object) customTimings).Handle);
					__args [16] = new JniArgumentValue ((isActive == null) ? IntPtr.Zero : ((global::Java.Lang.Object) isActive).Handle);
					__args [17] = new JniArgumentValue ((action == null) ? IntPtr.Zero : ((global::Java.Lang.Object) action).Handle);
					__args [18] = new JniArgumentValue ((error == null) ? IntPtr.Zero : ((global::Java.Lang.Object) error).Handle);
					__args [19] = new JniArgumentValue ((crash == null) ? IntPtr.Zero : ((global::Java.Lang.Object) crash).Handle);
					__args [20] = new JniArgumentValue ((longTask == null) ? IntPtr.Zero : ((global::Java.Lang.Object) longTask).Handle);
					__args [21] = new JniArgumentValue ((resource == null) ? IntPtr.Zero : ((global::Java.Lang.Object) resource).Handle);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.View> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_id);
					JNIEnv.DeleteLocalRef (native_referrer);
					JNIEnv.DeleteLocalRef (native_url);
					global::System.GC.KeepAlive (loadingTime);
					global::System.GC.KeepAlive (loadingType);
					global::System.GC.KeepAlive (firstContentfulPaint);
					global::System.GC.KeepAlive (largestContentfulPaint);
					global::System.GC.KeepAlive (firstInputDelay);
					global::System.GC.KeepAlive (firstInputTime);
					global::System.GC.KeepAlive (cumulativeLayoutShift);
					global::System.GC.KeepAlive (domComplete);
					global::System.GC.KeepAlive (domContentLoaded);
					global::System.GC.KeepAlive (domInteractive);
					global::System.GC.KeepAlive (loadEvent);
					global::System.GC.KeepAlive (customTimings);
					global::System.GC.KeepAlive (isActive);
					global::System.GC.KeepAlive (action);
					global::System.GC.KeepAlive (error);
					global::System.GC.KeepAlive (crash);
					global::System.GC.KeepAlive (longTask);
					global::System.GC.KeepAlive (resource);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.View']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ViewEvent$View;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ViewEvent.View FromJson (string serializedObject)
			{
				const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ViewEvent$View;";
				IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_serializedObject);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.View> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_serializedObject);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent.View']/method[@name='isActive' and count(parameter)=0]"
			[Register ("isActive", "()Ljava/lang/Boolean;", "")]
			public unsafe global::Java.Lang.Boolean IsActive ()
			{
				const string __id = "isActive.()Ljava/lang/Boolean;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ViewEvent", typeof (ViewEvent));

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

		internal ViewEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent']/constructor[@name='ViewEvent' and count(parameter)=8 and parameter[1][@type='long'] and parameter[2][@type='com.datadog.android.rum.model.ViewEvent.Application'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.datadog.android.rum.model.ViewEvent.Session'] and parameter[5][@type='com.datadog.android.rum.model.ViewEvent.View'] and parameter[6][@type='com.datadog.android.rum.model.ViewEvent.Usr'] and parameter[7][@type='com.datadog.android.rum.model.ViewEvent.Connectivity'] and parameter[8][@type='com.datadog.android.rum.model.ViewEvent.Dd']]"
		[Register (".ctor", "(JLcom/datadog/android/rum/model/ViewEvent$Application;Ljava/lang/String;Lcom/datadog/android/rum/model/ViewEvent$Session;Lcom/datadog/android/rum/model/ViewEvent$View;Lcom/datadog/android/rum/model/ViewEvent$Usr;Lcom/datadog/android/rum/model/ViewEvent$Connectivity;Lcom/datadog/android/rum/model/ViewEvent$Dd;)V", "")]
		public unsafe ViewEvent (long date, global::Com.Datadog.Android.Rum.Model.ViewEvent.Application application, string service, global::Com.Datadog.Android.Rum.Model.ViewEvent.Session session, global::Com.Datadog.Android.Rum.Model.ViewEvent.View view, global::Com.Datadog.Android.Rum.Model.ViewEvent.Usr usr, global::Com.Datadog.Android.Rum.Model.ViewEvent.Connectivity connectivity, global::Com.Datadog.Android.Rum.Model.ViewEvent.Dd dd) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(JLcom/datadog/android/rum/model/ViewEvent$Application;Ljava/lang/String;Lcom/datadog/android/rum/model/ViewEvent$Session;Lcom/datadog/android/rum/model/ViewEvent$View;Lcom/datadog/android/rum/model/ViewEvent$Usr;Lcom/datadog/android/rum/model/ViewEvent$Connectivity;Lcom/datadog/android/rum/model/ViewEvent$Dd;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_service = JNIEnv.NewString (service);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [8];
				__args [0] = new JniArgumentValue (date);
				__args [1] = new JniArgumentValue ((application == null) ? IntPtr.Zero : ((global::Java.Lang.Object) application).Handle);
				__args [2] = new JniArgumentValue (native_service);
				__args [3] = new JniArgumentValue ((session == null) ? IntPtr.Zero : ((global::Java.Lang.Object) session).Handle);
				__args [4] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [5] = new JniArgumentValue ((usr == null) ? IntPtr.Zero : ((global::Java.Lang.Object) usr).Handle);
				__args [6] = new JniArgumentValue ((connectivity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) connectivity).Handle);
				__args [7] = new JniArgumentValue ((dd == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dd).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_service);
				global::System.GC.KeepAlive (application);
				global::System.GC.KeepAlive (session);
				global::System.GC.KeepAlive (view);
				global::System.GC.KeepAlive (usr);
				global::System.GC.KeepAlive (connectivity);
				global::System.GC.KeepAlive (dd);
			}
		}

		public unsafe long Date {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent']/method[@name='getDate' and count(parameter)=0]"
			[Register ("getDate", "()J", "")]
			get {
				const string __id = "getDate.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe string Service {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent']/method[@name='getService' and count(parameter)=0]"
			[Register ("getService", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getService.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent']/method[@name='component1' and count(parameter)=0]"
		[Register ("component1", "()J", "")]
		public unsafe long Component1 ()
		{
			const string __id = "component1.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent']/method[@name='component2' and count(parameter)=0]"
		[Register ("component2", "()Lcom/datadog/android/rum/model/ViewEvent$Application;", "")]
		public unsafe global::Com.Datadog.Android.Rum.Model.ViewEvent.Application Component2 ()
		{
			const string __id = "component2.()Lcom/datadog/android/rum/model/ViewEvent$Application;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.Application> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent']/method[@name='component3' and count(parameter)=0]"
		[Register ("component3", "()Ljava/lang/String;", "")]
		public unsafe string Component3 ()
		{
			const string __id = "component3.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent']/method[@name='component4' and count(parameter)=0]"
		[Register ("component4", "()Lcom/datadog/android/rum/model/ViewEvent$Session;", "")]
		public unsafe global::Com.Datadog.Android.Rum.Model.ViewEvent.Session Component4 ()
		{
			const string __id = "component4.()Lcom/datadog/android/rum/model/ViewEvent$Session;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.Session> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent']/method[@name='component5' and count(parameter)=0]"
		[Register ("component5", "()Lcom/datadog/android/rum/model/ViewEvent$View;", "")]
		public unsafe global::Com.Datadog.Android.Rum.Model.ViewEvent.View Component5 ()
		{
			const string __id = "component5.()Lcom/datadog/android/rum/model/ViewEvent$View;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.View> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent']/method[@name='component6' and count(parameter)=0]"
		[Register ("component6", "()Lcom/datadog/android/rum/model/ViewEvent$Usr;", "")]
		public unsafe global::Com.Datadog.Android.Rum.Model.ViewEvent.Usr Component6 ()
		{
			const string __id = "component6.()Lcom/datadog/android/rum/model/ViewEvent$Usr;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.Usr> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent']/method[@name='component7' and count(parameter)=0]"
		[Register ("component7", "()Lcom/datadog/android/rum/model/ViewEvent$Connectivity;", "")]
		public unsafe global::Com.Datadog.Android.Rum.Model.ViewEvent.Connectivity Component7 ()
		{
			const string __id = "component7.()Lcom/datadog/android/rum/model/ViewEvent$Connectivity;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.Connectivity> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent']/method[@name='component8' and count(parameter)=0]"
		[Register ("component8", "()Lcom/datadog/android/rum/model/ViewEvent$Dd;", "")]
		public unsafe global::Com.Datadog.Android.Rum.Model.ViewEvent.Dd Component8 ()
		{
			const string __id = "component8.()Lcom/datadog/android/rum/model/ViewEvent$Dd;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.Dd> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent']/method[@name='copy' and count(parameter)=8 and parameter[1][@type='long'] and parameter[2][@type='com.datadog.android.rum.model.ViewEvent.Application'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.datadog.android.rum.model.ViewEvent.Session'] and parameter[5][@type='com.datadog.android.rum.model.ViewEvent.View'] and parameter[6][@type='com.datadog.android.rum.model.ViewEvent.Usr'] and parameter[7][@type='com.datadog.android.rum.model.ViewEvent.Connectivity'] and parameter[8][@type='com.datadog.android.rum.model.ViewEvent.Dd']]"
		[Register ("copy", "(JLcom/datadog/android/rum/model/ViewEvent$Application;Ljava/lang/String;Lcom/datadog/android/rum/model/ViewEvent$Session;Lcom/datadog/android/rum/model/ViewEvent$View;Lcom/datadog/android/rum/model/ViewEvent$Usr;Lcom/datadog/android/rum/model/ViewEvent$Connectivity;Lcom/datadog/android/rum/model/ViewEvent$Dd;)Lcom/datadog/android/rum/model/ViewEvent;", "")]
		public unsafe global::Com.Datadog.Android.Rum.Model.ViewEvent Copy (long date, global::Com.Datadog.Android.Rum.Model.ViewEvent.Application application, string service, global::Com.Datadog.Android.Rum.Model.ViewEvent.Session session, global::Com.Datadog.Android.Rum.Model.ViewEvent.View view, global::Com.Datadog.Android.Rum.Model.ViewEvent.Usr usr, global::Com.Datadog.Android.Rum.Model.ViewEvent.Connectivity connectivity, global::Com.Datadog.Android.Rum.Model.ViewEvent.Dd dd)
		{
			const string __id = "copy.(JLcom/datadog/android/rum/model/ViewEvent$Application;Ljava/lang/String;Lcom/datadog/android/rum/model/ViewEvent$Session;Lcom/datadog/android/rum/model/ViewEvent$View;Lcom/datadog/android/rum/model/ViewEvent$Usr;Lcom/datadog/android/rum/model/ViewEvent$Connectivity;Lcom/datadog/android/rum/model/ViewEvent$Dd;)Lcom/datadog/android/rum/model/ViewEvent;";
			IntPtr native_service = JNIEnv.NewString (service);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [8];
				__args [0] = new JniArgumentValue (date);
				__args [1] = new JniArgumentValue ((application == null) ? IntPtr.Zero : ((global::Java.Lang.Object) application).Handle);
				__args [2] = new JniArgumentValue (native_service);
				__args [3] = new JniArgumentValue ((session == null) ? IntPtr.Zero : ((global::Java.Lang.Object) session).Handle);
				__args [4] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [5] = new JniArgumentValue ((usr == null) ? IntPtr.Zero : ((global::Java.Lang.Object) usr).Handle);
				__args [6] = new JniArgumentValue ((connectivity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) connectivity).Handle);
				__args [7] = new JniArgumentValue ((dd == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dd).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_service);
				global::System.GC.KeepAlive (application);
				global::System.GC.KeepAlive (session);
				global::System.GC.KeepAlive (view);
				global::System.GC.KeepAlive (usr);
				global::System.GC.KeepAlive (connectivity);
				global::System.GC.KeepAlive (dd);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ViewEvent;", "")]
		public static unsafe global::Com.Datadog.Android.Rum.Model.ViewEvent FromJson (string serializedObject)
		{
			const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ViewEvent;";
			IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_serializedObject);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_serializedObject);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent']/method[@name='getApplication' and count(parameter)=0]"
		[Register ("getApplication", "()Lcom/datadog/android/rum/model/ViewEvent$Application;", "")]
		public unsafe global::Com.Datadog.Android.Rum.Model.ViewEvent.Application GetApplication ()
		{
			const string __id = "getApplication.()Lcom/datadog/android/rum/model/ViewEvent$Application;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.Application> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent']/method[@name='getConnectivity' and count(parameter)=0]"
		[Register ("getConnectivity", "()Lcom/datadog/android/rum/model/ViewEvent$Connectivity;", "")]
		public unsafe global::Com.Datadog.Android.Rum.Model.ViewEvent.Connectivity GetConnectivity ()
		{
			const string __id = "getConnectivity.()Lcom/datadog/android/rum/model/ViewEvent$Connectivity;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.Connectivity> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent']/method[@name='getDd' and count(parameter)=0]"
		[Register ("getDd", "()Lcom/datadog/android/rum/model/ViewEvent$Dd;", "")]
		public unsafe global::Com.Datadog.Android.Rum.Model.ViewEvent.Dd GetDd ()
		{
			const string __id = "getDd.()Lcom/datadog/android/rum/model/ViewEvent$Dd;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.Dd> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent']/method[@name='getSession' and count(parameter)=0]"
		[Register ("getSession", "()Lcom/datadog/android/rum/model/ViewEvent$Session;", "")]
		public unsafe global::Com.Datadog.Android.Rum.Model.ViewEvent.Session GetSession ()
		{
			const string __id = "getSession.()Lcom/datadog/android/rum/model/ViewEvent$Session;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.Session> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent']/method[@name='getType' and count(parameter)=0]"
		[Register ("getType", "()Ljava/lang/String;", "")]
		public new unsafe string GetType ()
		{
			const string __id = "getType.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent']/method[@name='getUsr' and count(parameter)=0]"
		[Register ("getUsr", "()Lcom/datadog/android/rum/model/ViewEvent$Usr;", "")]
		public unsafe global::Com.Datadog.Android.Rum.Model.ViewEvent.Usr GetUsr ()
		{
			const string __id = "getUsr.()Lcom/datadog/android/rum/model/ViewEvent$Usr;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.Usr> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ViewEvent']/method[@name='getView' and count(parameter)=0]"
		[Register ("getView", "()Lcom/datadog/android/rum/model/ViewEvent$View;", "")]
		public unsafe global::Com.Datadog.Android.Rum.Model.ViewEvent.View GetView ()
		{
			const string __id = "getView.()Lcom/datadog/android/rum/model/ViewEvent$View;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ViewEvent.View> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
