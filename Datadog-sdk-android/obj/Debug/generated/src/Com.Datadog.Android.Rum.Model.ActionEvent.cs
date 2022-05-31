using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Datadog.Android.Rum.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent']"
	[global::Android.Runtime.Register ("com/datadog/android/rum/model/ActionEvent", DoNotGenerateAcw=true)]
	public sealed partial class ActionEvent : global::Java.Lang.Object {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Action']"
		[global::Android.Runtime.Register ("com/datadog/android/rum/model/ActionEvent$Action", DoNotGenerateAcw=true)]
		public sealed partial class Action : global::Java.Lang.Object {
			// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Action.Companion']"
			[global::Android.Runtime.Register ("com/datadog/android/rum/model/ActionEvent$Action$Companion", DoNotGenerateAcw=true)]
			public sealed partial class Companion : global::Java.Lang.Object {
				static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ActionEvent$Action$Companion", typeof (Companion));

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

				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Action.Companion']/constructor[@name='ActionEvent.Action.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
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

				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Action.Companion']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ActionEvent$Action;", "")]
				public unsafe global::Com.Datadog.Android.Rum.Model.ActionEvent.Action FromJson (string serializedObject)
				{
					const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ActionEvent$Action;";
					IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_serializedObject);
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.Action> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
						JNIEnv.DeleteLocalRef (native_serializedObject);
					}
				}

			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ActionEvent$Action", typeof (Action));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Action']/constructor[@name='ActionEvent.Action' and count(parameter)=8 and parameter[1][@type='com.datadog.android.rum.model.ActionEvent.ActionType'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Long'] and parameter[4][@type='com.datadog.android.rum.model.ActionEvent.Target'] and parameter[5][@type='com.datadog.android.rum.model.ActionEvent.Error'] and parameter[6][@type='com.datadog.android.rum.model.ActionEvent.Crash'] and parameter[7][@type='com.datadog.android.rum.model.ActionEvent.LongTask'] and parameter[8][@type='com.datadog.android.rum.model.ActionEvent.Resource']]"
			[Register (".ctor", "(Lcom/datadog/android/rum/model/ActionEvent$ActionType;Ljava/lang/String;Ljava/lang/Long;Lcom/datadog/android/rum/model/ActionEvent$Target;Lcom/datadog/android/rum/model/ActionEvent$Error;Lcom/datadog/android/rum/model/ActionEvent$Crash;Lcom/datadog/android/rum/model/ActionEvent$LongTask;Lcom/datadog/android/rum/model/ActionEvent$Resource;)V", "")]
			public unsafe Action (global::Com.Datadog.Android.Rum.Model.ActionEvent.ActionType type, string id, global::Java.Lang.Long loadingTime, global::Com.Datadog.Android.Rum.Model.ActionEvent.Target target, global::Com.Datadog.Android.Rum.Model.ActionEvent.Error error, global::Com.Datadog.Android.Rum.Model.ActionEvent.Crash crash, global::Com.Datadog.Android.Rum.Model.ActionEvent.LongTask longTask, global::Com.Datadog.Android.Rum.Model.ActionEvent.Resource resource) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Lcom/datadog/android/rum/model/ActionEvent$ActionType;Ljava/lang/String;Ljava/lang/Long;Lcom/datadog/android/rum/model/ActionEvent$Target;Lcom/datadog/android/rum/model/ActionEvent$Error;Lcom/datadog/android/rum/model/ActionEvent$Crash;Lcom/datadog/android/rum/model/ActionEvent$LongTask;Lcom/datadog/android/rum/model/ActionEvent$Resource;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_id = JNIEnv.NewString (id);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [8];
					__args [0] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
					__args [1] = new JniArgumentValue (native_id);
					__args [2] = new JniArgumentValue ((loadingTime == null) ? IntPtr.Zero : ((global::Java.Lang.Object) loadingTime).Handle);
					__args [3] = new JniArgumentValue ((target == null) ? IntPtr.Zero : ((global::Java.Lang.Object) target).Handle);
					__args [4] = new JniArgumentValue ((error == null) ? IntPtr.Zero : ((global::Java.Lang.Object) error).Handle);
					__args [5] = new JniArgumentValue ((crash == null) ? IntPtr.Zero : ((global::Java.Lang.Object) crash).Handle);
					__args [6] = new JniArgumentValue ((longTask == null) ? IntPtr.Zero : ((global::Java.Lang.Object) longTask).Handle);
					__args [7] = new JniArgumentValue ((resource == null) ? IntPtr.Zero : ((global::Java.Lang.Object) resource).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_id);
					global::System.GC.KeepAlive (type);
					global::System.GC.KeepAlive (loadingTime);
					global::System.GC.KeepAlive (target);
					global::System.GC.KeepAlive (error);
					global::System.GC.KeepAlive (crash);
					global::System.GC.KeepAlive (longTask);
					global::System.GC.KeepAlive (resource);
				}
			}

			public unsafe global::Com.Datadog.Android.Rum.Model.ActionEvent.Crash Crash {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Action']/method[@name='getCrash' and count(parameter)=0]"
				[Register ("getCrash", "()Lcom/datadog/android/rum/model/ActionEvent$Crash;", "")]
				get {
					const string __id = "getCrash.()Lcom/datadog/android/rum/model/ActionEvent$Crash;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.Crash> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe global::Com.Datadog.Android.Rum.Model.ActionEvent.Error Error {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Action']/method[@name='getError' and count(parameter)=0]"
				[Register ("getError", "()Lcom/datadog/android/rum/model/ActionEvent$Error;", "")]
				get {
					const string __id = "getError.()Lcom/datadog/android/rum/model/ActionEvent$Error;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.Error> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe string Id {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Action']/method[@name='getId' and count(parameter)=0]"
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

			public unsafe global::Java.Lang.Long LoadingTime {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Action']/method[@name='getLoadingTime' and count(parameter)=0]"
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

			public unsafe global::Com.Datadog.Android.Rum.Model.ActionEvent.LongTask LongTask {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Action']/method[@name='getLongTask' and count(parameter)=0]"
				[Register ("getLongTask", "()Lcom/datadog/android/rum/model/ActionEvent$LongTask;", "")]
				get {
					const string __id = "getLongTask.()Lcom/datadog/android/rum/model/ActionEvent$LongTask;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.LongTask> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe global::Com.Datadog.Android.Rum.Model.ActionEvent.Resource Resource {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Action']/method[@name='getResource' and count(parameter)=0]"
				[Register ("getResource", "()Lcom/datadog/android/rum/model/ActionEvent$Resource;", "")]
				get {
					const string __id = "getResource.()Lcom/datadog/android/rum/model/ActionEvent$Resource;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.Resource> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe global::Com.Datadog.Android.Rum.Model.ActionEvent.Target Target {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Action']/method[@name='getTarget' and count(parameter)=0]"
				[Register ("getTarget", "()Lcom/datadog/android/rum/model/ActionEvent$Target;", "")]
				get {
					const string __id = "getTarget.()Lcom/datadog/android/rum/model/ActionEvent$Target;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.Target> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe global::Com.Datadog.Android.Rum.Model.ActionEvent.ActionType Type {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Action']/method[@name='getType' and count(parameter)=0]"
				[Register ("getType", "()Lcom/datadog/android/rum/model/ActionEvent$ActionType;", "")]
				get {
					const string __id = "getType.()Lcom/datadog/android/rum/model/ActionEvent$ActionType;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.ActionType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Action']/method[@name='component1' and count(parameter)=0]"
			[Register ("component1", "()Lcom/datadog/android/rum/model/ActionEvent$ActionType;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ActionEvent.ActionType Component1 ()
			{
				const string __id = "component1.()Lcom/datadog/android/rum/model/ActionEvent$ActionType;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.ActionType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Action']/method[@name='component2' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Action']/method[@name='component3' and count(parameter)=0]"
			[Register ("component3", "()Ljava/lang/Long;", "")]
			public unsafe global::Java.Lang.Long Component3 ()
			{
				const string __id = "component3.()Ljava/lang/Long;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Action']/method[@name='component4' and count(parameter)=0]"
			[Register ("component4", "()Lcom/datadog/android/rum/model/ActionEvent$Target;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ActionEvent.Target Component4 ()
			{
				const string __id = "component4.()Lcom/datadog/android/rum/model/ActionEvent$Target;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.Target> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Action']/method[@name='component5' and count(parameter)=0]"
			[Register ("component5", "()Lcom/datadog/android/rum/model/ActionEvent$Error;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ActionEvent.Error Component5 ()
			{
				const string __id = "component5.()Lcom/datadog/android/rum/model/ActionEvent$Error;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.Error> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Action']/method[@name='component6' and count(parameter)=0]"
			[Register ("component6", "()Lcom/datadog/android/rum/model/ActionEvent$Crash;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ActionEvent.Crash Component6 ()
			{
				const string __id = "component6.()Lcom/datadog/android/rum/model/ActionEvent$Crash;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.Crash> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Action']/method[@name='component7' and count(parameter)=0]"
			[Register ("component7", "()Lcom/datadog/android/rum/model/ActionEvent$LongTask;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ActionEvent.LongTask Component7 ()
			{
				const string __id = "component7.()Lcom/datadog/android/rum/model/ActionEvent$LongTask;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.LongTask> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Action']/method[@name='component8' and count(parameter)=0]"
			[Register ("component8", "()Lcom/datadog/android/rum/model/ActionEvent$Resource;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ActionEvent.Resource Component8 ()
			{
				const string __id = "component8.()Lcom/datadog/android/rum/model/ActionEvent$Resource;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.Resource> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Action']/method[@name='copy' and count(parameter)=8 and parameter[1][@type='com.datadog.android.rum.model.ActionEvent.ActionType'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Long'] and parameter[4][@type='com.datadog.android.rum.model.ActionEvent.Target'] and parameter[5][@type='com.datadog.android.rum.model.ActionEvent.Error'] and parameter[6][@type='com.datadog.android.rum.model.ActionEvent.Crash'] and parameter[7][@type='com.datadog.android.rum.model.ActionEvent.LongTask'] and parameter[8][@type='com.datadog.android.rum.model.ActionEvent.Resource']]"
			[Register ("copy", "(Lcom/datadog/android/rum/model/ActionEvent$ActionType;Ljava/lang/String;Ljava/lang/Long;Lcom/datadog/android/rum/model/ActionEvent$Target;Lcom/datadog/android/rum/model/ActionEvent$Error;Lcom/datadog/android/rum/model/ActionEvent$Crash;Lcom/datadog/android/rum/model/ActionEvent$LongTask;Lcom/datadog/android/rum/model/ActionEvent$Resource;)Lcom/datadog/android/rum/model/ActionEvent$Action;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ActionEvent.Action Copy (global::Com.Datadog.Android.Rum.Model.ActionEvent.ActionType type, string id, global::Java.Lang.Long loadingTime, global::Com.Datadog.Android.Rum.Model.ActionEvent.Target target, global::Com.Datadog.Android.Rum.Model.ActionEvent.Error error, global::Com.Datadog.Android.Rum.Model.ActionEvent.Crash crash, global::Com.Datadog.Android.Rum.Model.ActionEvent.LongTask longTask, global::Com.Datadog.Android.Rum.Model.ActionEvent.Resource resource)
			{
				const string __id = "copy.(Lcom/datadog/android/rum/model/ActionEvent$ActionType;Ljava/lang/String;Ljava/lang/Long;Lcom/datadog/android/rum/model/ActionEvent$Target;Lcom/datadog/android/rum/model/ActionEvent$Error;Lcom/datadog/android/rum/model/ActionEvent$Crash;Lcom/datadog/android/rum/model/ActionEvent$LongTask;Lcom/datadog/android/rum/model/ActionEvent$Resource;)Lcom/datadog/android/rum/model/ActionEvent$Action;";
				IntPtr native_id = JNIEnv.NewString (id);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [8];
					__args [0] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
					__args [1] = new JniArgumentValue (native_id);
					__args [2] = new JniArgumentValue ((loadingTime == null) ? IntPtr.Zero : ((global::Java.Lang.Object) loadingTime).Handle);
					__args [3] = new JniArgumentValue ((target == null) ? IntPtr.Zero : ((global::Java.Lang.Object) target).Handle);
					__args [4] = new JniArgumentValue ((error == null) ? IntPtr.Zero : ((global::Java.Lang.Object) error).Handle);
					__args [5] = new JniArgumentValue ((crash == null) ? IntPtr.Zero : ((global::Java.Lang.Object) crash).Handle);
					__args [6] = new JniArgumentValue ((longTask == null) ? IntPtr.Zero : ((global::Java.Lang.Object) longTask).Handle);
					__args [7] = new JniArgumentValue ((resource == null) ? IntPtr.Zero : ((global::Java.Lang.Object) resource).Handle);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.Action> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_id);
					global::System.GC.KeepAlive (type);
					global::System.GC.KeepAlive (loadingTime);
					global::System.GC.KeepAlive (target);
					global::System.GC.KeepAlive (error);
					global::System.GC.KeepAlive (crash);
					global::System.GC.KeepAlive (longTask);
					global::System.GC.KeepAlive (resource);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Action']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ActionEvent$Action;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ActionEvent.Action FromJson (string serializedObject)
			{
				const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ActionEvent$Action;";
				IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_serializedObject);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.Action> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_serializedObject);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.ActionType']"
		[global::Android.Runtime.Register ("com/datadog/android/rum/model/ActionEvent$ActionType", DoNotGenerateAcw=true)]
		public sealed partial class ActionType : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.ActionType']/field[@name='APPLICATION_START']"
			[Register ("APPLICATION_START")]
			public static global::Com.Datadog.Android.Rum.Model.ActionEvent.ActionType ApplicationStart {
				get {
					const string __id = "APPLICATION_START.Lcom/datadog/android/rum/model/ActionEvent$ActionType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.ActionType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.ActionType']/field[@name='BACK']"
			[Register ("BACK")]
			public static global::Com.Datadog.Android.Rum.Model.ActionEvent.ActionType Back {
				get {
					const string __id = "BACK.Lcom/datadog/android/rum/model/ActionEvent$ActionType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.ActionType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.ActionType']/field[@name='CLICK']"
			[Register ("CLICK")]
			public static global::Com.Datadog.Android.Rum.Model.ActionEvent.ActionType Click {
				get {
					const string __id = "CLICK.Lcom/datadog/android/rum/model/ActionEvent$ActionType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.ActionType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.ActionType']/field[@name='CUSTOM']"
			[Register ("CUSTOM")]
			public static global::Com.Datadog.Android.Rum.Model.ActionEvent.ActionType Custom {
				get {
					const string __id = "CUSTOM.Lcom/datadog/android/rum/model/ActionEvent$ActionType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.ActionType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.ActionType']/field[@name='SCROLL']"
			[Register ("SCROLL")]
			public static global::Com.Datadog.Android.Rum.Model.ActionEvent.ActionType Scroll {
				get {
					const string __id = "SCROLL.Lcom/datadog/android/rum/model/ActionEvent$ActionType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.ActionType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.ActionType']/field[@name='SWIPE']"
			[Register ("SWIPE")]
			public static global::Com.Datadog.Android.Rum.Model.ActionEvent.ActionType Swipe {
				get {
					const string __id = "SWIPE.Lcom/datadog/android/rum/model/ActionEvent$ActionType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.ActionType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.ActionType']/field[@name='TAP']"
			[Register ("TAP")]
			public static global::Com.Datadog.Android.Rum.Model.ActionEvent.ActionType Tap {
				get {
					const string __id = "TAP.Lcom/datadog/android/rum/model/ActionEvent$ActionType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.ActionType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.ActionType.Companion']"
			[global::Android.Runtime.Register ("com/datadog/android/rum/model/ActionEvent$ActionType$Companion", DoNotGenerateAcw=true)]
			public sealed partial class Companion : global::Java.Lang.Object {
				static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ActionEvent$ActionType$Companion", typeof (Companion));

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

				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.ActionType.Companion']/constructor[@name='ActionEvent.ActionType.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
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

				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.ActionType.Companion']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ActionEvent$ActionType;", "")]
				public unsafe global::Com.Datadog.Android.Rum.Model.ActionEvent.ActionType FromJson (string serializedObject)
				{
					const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ActionEvent$ActionType;";
					IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_serializedObject);
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.ActionType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
						JNIEnv.DeleteLocalRef (native_serializedObject);
					}
				}

			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ActionEvent$ActionType", typeof (ActionType));

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

			internal ActionType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.ActionType']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ActionEvent$ActionType;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ActionEvent.ActionType FromJson (string serializedObject)
			{
				const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ActionEvent$ActionType;";
				IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_serializedObject);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.ActionType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_serializedObject);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.ActionType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ActionEvent$ActionType;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ActionEvent.ActionType ValueOf (string p0)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ActionEvent$ActionType;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.ActionType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.ActionType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/datadog/android/rum/model/ActionEvent$ActionType;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ActionEvent.ActionType[] Values ()
			{
				const string __id = "values.()[Lcom/datadog/android/rum/model/ActionEvent$ActionType;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Datadog.Android.Rum.Model.ActionEvent.ActionType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Datadog.Android.Rum.Model.ActionEvent.ActionType));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Application']"
		[global::Android.Runtime.Register ("com/datadog/android/rum/model/ActionEvent$Application", DoNotGenerateAcw=true)]
		public sealed partial class Application : global::Java.Lang.Object {
			// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Application.Companion']"
			[global::Android.Runtime.Register ("com/datadog/android/rum/model/ActionEvent$Application$Companion", DoNotGenerateAcw=true)]
			public sealed partial class Companion : global::Java.Lang.Object {
				static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ActionEvent$Application$Companion", typeof (Companion));

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

				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Application.Companion']/constructor[@name='ActionEvent.Application.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
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

				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Application.Companion']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ActionEvent$Application;", "")]
				public unsafe global::Com.Datadog.Android.Rum.Model.ActionEvent.Application FromJson (string serializedObject)
				{
					const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ActionEvent$Application;";
					IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_serializedObject);
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.Application> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
						JNIEnv.DeleteLocalRef (native_serializedObject);
					}
				}

			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ActionEvent$Application", typeof (Application));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Application']/constructor[@name='ActionEvent.Application' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Application']/method[@name='getId' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Application']/method[@name='component1' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Application']/method[@name='copy' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("copy", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ActionEvent$Application;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ActionEvent.Application Copy (string id)
			{
				const string __id = "copy.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ActionEvent$Application;";
				IntPtr native_id = JNIEnv.NewString (id);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_id);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.Application> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_id);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Application']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ActionEvent$Application;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ActionEvent.Application FromJson (string serializedObject)
			{
				const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ActionEvent$Application;";
				IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_serializedObject);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.Application> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_serializedObject);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Cellular']"
		[global::Android.Runtime.Register ("com/datadog/android/rum/model/ActionEvent$Cellular", DoNotGenerateAcw=true)]
		public sealed partial class Cellular : global::Java.Lang.Object {
			// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Cellular.Companion']"
			[global::Android.Runtime.Register ("com/datadog/android/rum/model/ActionEvent$Cellular$Companion", DoNotGenerateAcw=true)]
			public sealed partial class Companion : global::Java.Lang.Object {
				static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ActionEvent$Cellular$Companion", typeof (Companion));

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

				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Cellular.Companion']/constructor[@name='ActionEvent.Cellular.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
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

				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Cellular.Companion']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ActionEvent$Cellular;", "")]
				public unsafe global::Com.Datadog.Android.Rum.Model.ActionEvent.Cellular FromJson (string serializedObject)
				{
					const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ActionEvent$Cellular;";
					IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_serializedObject);
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.Cellular> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
						JNIEnv.DeleteLocalRef (native_serializedObject);
					}
				}

			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ActionEvent$Cellular", typeof (Cellular));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Cellular']/constructor[@name='ActionEvent.Cellular' and count(parameter)=0]"
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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Cellular']/constructor[@name='ActionEvent.Cellular' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
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
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Cellular']/method[@name='getCarrierName' and count(parameter)=0]"
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
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Cellular']/method[@name='getTechnology' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Cellular']/method[@name='component1' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Cellular']/method[@name='component2' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Cellular']/method[@name='copy' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register ("copy", "(Ljava/lang/String;Ljava/lang/String;)Lcom/datadog/android/rum/model/ActionEvent$Cellular;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ActionEvent.Cellular Copy (string technology, string carrierName)
			{
				const string __id = "copy.(Ljava/lang/String;Ljava/lang/String;)Lcom/datadog/android/rum/model/ActionEvent$Cellular;";
				IntPtr native_technology = JNIEnv.NewString (technology);
				IntPtr native_carrierName = JNIEnv.NewString (carrierName);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_technology);
					__args [1] = new JniArgumentValue (native_carrierName);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.Cellular> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_technology);
					JNIEnv.DeleteLocalRef (native_carrierName);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Cellular']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ActionEvent$Cellular;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ActionEvent.Cellular FromJson (string serializedObject)
			{
				const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ActionEvent$Cellular;";
				IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_serializedObject);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.Cellular> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_serializedObject);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Companion']"
		[global::Android.Runtime.Register ("com/datadog/android/rum/model/ActionEvent$Companion", DoNotGenerateAcw=true)]
		public sealed partial class Companion : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ActionEvent$Companion", typeof (Companion));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Companion']/constructor[@name='ActionEvent.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Companion']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ActionEvent;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ActionEvent FromJson (string serializedObject)
			{
				const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ActionEvent;";
				IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_serializedObject);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_serializedObject);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Connectivity']"
		[global::Android.Runtime.Register ("com/datadog/android/rum/model/ActionEvent$Connectivity", DoNotGenerateAcw=true)]
		public sealed partial class Connectivity : global::Java.Lang.Object {
			// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Connectivity.Companion']"
			[global::Android.Runtime.Register ("com/datadog/android/rum/model/ActionEvent$Connectivity$Companion", DoNotGenerateAcw=true)]
			public sealed partial class Companion : global::Java.Lang.Object {
				static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ActionEvent$Connectivity$Companion", typeof (Companion));

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

				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Connectivity.Companion']/constructor[@name='ActionEvent.Connectivity.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
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

				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Connectivity.Companion']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ActionEvent$Connectivity;", "")]
				public unsafe global::Com.Datadog.Android.Rum.Model.ActionEvent.Connectivity FromJson (string serializedObject)
				{
					const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ActionEvent$Connectivity;";
					IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_serializedObject);
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.Connectivity> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
						JNIEnv.DeleteLocalRef (native_serializedObject);
					}
				}

			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ActionEvent$Connectivity", typeof (Connectivity));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Connectivity']/constructor[@name='ActionEvent.Connectivity' and count(parameter)=3 and parameter[1][@type='com.datadog.android.rum.model.ActionEvent.Status'] and parameter[2][@type='java.util.List&lt;? extends com.datadog.android.rum.model.ActionEvent.Interface&gt;'] and parameter[3][@type='com.datadog.android.rum.model.ActionEvent.Cellular']]"
			[Register (".ctor", "(Lcom/datadog/android/rum/model/ActionEvent$Status;Ljava/util/List;Lcom/datadog/android/rum/model/ActionEvent$Cellular;)V", "")]
			public unsafe Connectivity (global::Com.Datadog.Android.Rum.Model.ActionEvent.Status status, global::System.Collections.Generic.IList<global::Com.Datadog.Android.Rum.Model.ActionEvent.Interface> interfaces, global::Com.Datadog.Android.Rum.Model.ActionEvent.Cellular cellular) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Lcom/datadog/android/rum/model/ActionEvent$Status;Ljava/util/List;Lcom/datadog/android/rum/model/ActionEvent$Cellular;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_interfaces = global::Android.Runtime.JavaList<global::Com.Datadog.Android.Rum.Model.ActionEvent.Interface>.ToLocalJniHandle (interfaces);
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

			public unsafe global::Com.Datadog.Android.Rum.Model.ActionEvent.Cellular Cellular {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Connectivity']/method[@name='getCellular' and count(parameter)=0]"
				[Register ("getCellular", "()Lcom/datadog/android/rum/model/ActionEvent$Cellular;", "")]
				get {
					const string __id = "getCellular.()Lcom/datadog/android/rum/model/ActionEvent$Cellular;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.Cellular> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe global::System.Collections.Generic.IList<global::Com.Datadog.Android.Rum.Model.ActionEvent.Interface> Interfaces {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Connectivity']/method[@name='getInterfaces' and count(parameter)=0]"
				[Register ("getInterfaces", "()Ljava/util/List;", "")]
				get {
					const string __id = "getInterfaces.()Ljava/util/List;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Android.Runtime.JavaList<global::Com.Datadog.Android.Rum.Model.ActionEvent.Interface>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe global::Com.Datadog.Android.Rum.Model.ActionEvent.Status Status {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Connectivity']/method[@name='getStatus' and count(parameter)=0]"
				[Register ("getStatus", "()Lcom/datadog/android/rum/model/ActionEvent$Status;", "")]
				get {
					const string __id = "getStatus.()Lcom/datadog/android/rum/model/ActionEvent$Status;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.Status> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Connectivity']/method[@name='component1' and count(parameter)=0]"
			[Register ("component1", "()Lcom/datadog/android/rum/model/ActionEvent$Status;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ActionEvent.Status Component1 ()
			{
				const string __id = "component1.()Lcom/datadog/android/rum/model/ActionEvent$Status;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.Status> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Connectivity']/method[@name='component2' and count(parameter)=0]"
			[Register ("component2", "()Ljava/util/List;", "")]
			public unsafe global::System.Collections.Generic.IList<global::Com.Datadog.Android.Rum.Model.ActionEvent.Interface> Component2 ()
			{
				const string __id = "component2.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Datadog.Android.Rum.Model.ActionEvent.Interface>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Connectivity']/method[@name='component3' and count(parameter)=0]"
			[Register ("component3", "()Lcom/datadog/android/rum/model/ActionEvent$Cellular;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ActionEvent.Cellular Component3 ()
			{
				const string __id = "component3.()Lcom/datadog/android/rum/model/ActionEvent$Cellular;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.Cellular> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Connectivity']/method[@name='copy' and count(parameter)=3 and parameter[1][@type='com.datadog.android.rum.model.ActionEvent.Status'] and parameter[2][@type='java.util.List&lt;? extends com.datadog.android.rum.model.ActionEvent.Interface&gt;'] and parameter[3][@type='com.datadog.android.rum.model.ActionEvent.Cellular']]"
			[Register ("copy", "(Lcom/datadog/android/rum/model/ActionEvent$Status;Ljava/util/List;Lcom/datadog/android/rum/model/ActionEvent$Cellular;)Lcom/datadog/android/rum/model/ActionEvent$Connectivity;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ActionEvent.Connectivity Copy (global::Com.Datadog.Android.Rum.Model.ActionEvent.Status status, global::System.Collections.Generic.IList<global::Com.Datadog.Android.Rum.Model.ActionEvent.Interface> interfaces, global::Com.Datadog.Android.Rum.Model.ActionEvent.Cellular cellular)
			{
				const string __id = "copy.(Lcom/datadog/android/rum/model/ActionEvent$Status;Ljava/util/List;Lcom/datadog/android/rum/model/ActionEvent$Cellular;)Lcom/datadog/android/rum/model/ActionEvent$Connectivity;";
				IntPtr native_interfaces = global::Android.Runtime.JavaList<global::Com.Datadog.Android.Rum.Model.ActionEvent.Interface>.ToLocalJniHandle (interfaces);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue ((status == null) ? IntPtr.Zero : ((global::Java.Lang.Object) status).Handle);
					__args [1] = new JniArgumentValue (native_interfaces);
					__args [2] = new JniArgumentValue ((cellular == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cellular).Handle);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.Connectivity> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_interfaces);
					global::System.GC.KeepAlive (status);
					global::System.GC.KeepAlive (interfaces);
					global::System.GC.KeepAlive (cellular);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Connectivity']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ActionEvent$Connectivity;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ActionEvent.Connectivity FromJson (string serializedObject)
			{
				const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ActionEvent$Connectivity;";
				IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_serializedObject);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.Connectivity> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_serializedObject);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Crash']"
		[global::Android.Runtime.Register ("com/datadog/android/rum/model/ActionEvent$Crash", DoNotGenerateAcw=true)]
		public sealed partial class Crash : global::Java.Lang.Object {
			// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Crash.Companion']"
			[global::Android.Runtime.Register ("com/datadog/android/rum/model/ActionEvent$Crash$Companion", DoNotGenerateAcw=true)]
			public sealed partial class Companion : global::Java.Lang.Object {
				static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ActionEvent$Crash$Companion", typeof (Companion));

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

				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Crash.Companion']/constructor[@name='ActionEvent.Crash.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
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

				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Crash.Companion']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ActionEvent$Crash;", "")]
				public unsafe global::Com.Datadog.Android.Rum.Model.ActionEvent.Crash FromJson (string serializedObject)
				{
					const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ActionEvent$Crash;";
					IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_serializedObject);
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.Crash> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
						JNIEnv.DeleteLocalRef (native_serializedObject);
					}
				}

			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ActionEvent$Crash", typeof (Crash));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Crash']/constructor[@name='ActionEvent.Crash' and count(parameter)=1 and parameter[1][@type='long']]"
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
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Crash']/method[@name='getCount' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Crash']/method[@name='component1' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Crash']/method[@name='copy' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("copy", "(J)Lcom/datadog/android/rum/model/ActionEvent$Crash;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ActionEvent.Crash Copy (long count)
			{
				const string __id = "copy.(J)Lcom/datadog/android/rum/model/ActionEvent$Crash;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (count);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.Crash> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Crash']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ActionEvent$Crash;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ActionEvent.Crash FromJson (string serializedObject)
			{
				const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ActionEvent$Crash;";
				IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_serializedObject);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.Crash> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_serializedObject);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Dd']"
		[global::Android.Runtime.Register ("com/datadog/android/rum/model/ActionEvent$Dd", DoNotGenerateAcw=true)]
		public sealed partial class Dd : global::Java.Lang.Object {
			// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Dd.Companion']"
			[global::Android.Runtime.Register ("com/datadog/android/rum/model/ActionEvent$Dd$Companion", DoNotGenerateAcw=true)]
			public sealed partial class Companion : global::Java.Lang.Object {
				static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ActionEvent$Dd$Companion", typeof (Companion));

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

				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Dd.Companion']/constructor[@name='ActionEvent.Dd.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
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

				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Dd.Companion']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ActionEvent$Dd;", "")]
				public unsafe global::Com.Datadog.Android.Rum.Model.ActionEvent.Dd FromJson (string serializedObject)
				{
					const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ActionEvent$Dd;";
					IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_serializedObject);
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.Dd> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
						JNIEnv.DeleteLocalRef (native_serializedObject);
					}
				}

			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ActionEvent$Dd", typeof (Dd));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Dd']/constructor[@name='ActionEvent.Dd' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Dd () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

			public unsafe long FormatVersion {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Dd']/method[@name='getFormatVersion' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Dd']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ActionEvent$Dd;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ActionEvent.Dd FromJson (string serializedObject)
			{
				const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ActionEvent$Dd;";
				IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_serializedObject);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.Dd> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_serializedObject);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Error']"
		[global::Android.Runtime.Register ("com/datadog/android/rum/model/ActionEvent$Error", DoNotGenerateAcw=true)]
		public sealed partial class Error : global::Java.Lang.Object {
			// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Error.Companion']"
			[global::Android.Runtime.Register ("com/datadog/android/rum/model/ActionEvent$Error$Companion", DoNotGenerateAcw=true)]
			public sealed partial class Companion : global::Java.Lang.Object {
				static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ActionEvent$Error$Companion", typeof (Companion));

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

				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Error.Companion']/constructor[@name='ActionEvent.Error.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
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

				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Error.Companion']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ActionEvent$Error;", "")]
				public unsafe global::Com.Datadog.Android.Rum.Model.ActionEvent.Error FromJson (string serializedObject)
				{
					const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ActionEvent$Error;";
					IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_serializedObject);
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.Error> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
						JNIEnv.DeleteLocalRef (native_serializedObject);
					}
				}

			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ActionEvent$Error", typeof (Error));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Error']/constructor[@name='ActionEvent.Error' and count(parameter)=1 and parameter[1][@type='long']]"
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
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Error']/method[@name='getCount' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Error']/method[@name='component1' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Error']/method[@name='copy' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("copy", "(J)Lcom/datadog/android/rum/model/ActionEvent$Error;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ActionEvent.Error Copy (long count)
			{
				const string __id = "copy.(J)Lcom/datadog/android/rum/model/ActionEvent$Error;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (count);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.Error> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Error']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ActionEvent$Error;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ActionEvent.Error FromJson (string serializedObject)
			{
				const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ActionEvent$Error;";
				IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_serializedObject);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.Error> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_serializedObject);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Interface']"
		[global::Android.Runtime.Register ("com/datadog/android/rum/model/ActionEvent$Interface", DoNotGenerateAcw=true)]
		public sealed partial class Interface : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Interface']/field[@name='BLUETOOTH']"
			[Register ("BLUETOOTH")]
			public static global::Com.Datadog.Android.Rum.Model.ActionEvent.Interface Bluetooth {
				get {
					const string __id = "BLUETOOTH.Lcom/datadog/android/rum/model/ActionEvent$Interface;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.Interface> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Interface']/field[@name='CELLULAR']"
			[Register ("CELLULAR")]
			public static global::Com.Datadog.Android.Rum.Model.ActionEvent.Interface Cellular {
				get {
					const string __id = "CELLULAR.Lcom/datadog/android/rum/model/ActionEvent$Interface;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.Interface> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Interface']/field[@name='ETHERNET']"
			[Register ("ETHERNET")]
			public static global::Com.Datadog.Android.Rum.Model.ActionEvent.Interface Ethernet {
				get {
					const string __id = "ETHERNET.Lcom/datadog/android/rum/model/ActionEvent$Interface;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.Interface> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Interface']/field[@name='MIXED']"
			[Register ("MIXED")]
			public static global::Com.Datadog.Android.Rum.Model.ActionEvent.Interface Mixed {
				get {
					const string __id = "MIXED.Lcom/datadog/android/rum/model/ActionEvent$Interface;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.Interface> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Interface']/field[@name='NONE']"
			[Register ("NONE")]
			public static global::Com.Datadog.Android.Rum.Model.ActionEvent.Interface None {
				get {
					const string __id = "NONE.Lcom/datadog/android/rum/model/ActionEvent$Interface;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.Interface> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Interface']/field[@name='OTHER']"
			[Register ("OTHER")]
			public static global::Com.Datadog.Android.Rum.Model.ActionEvent.Interface Other {
				get {
					const string __id = "OTHER.Lcom/datadog/android/rum/model/ActionEvent$Interface;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.Interface> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Interface']/field[@name='UNKNOWN']"
			[Register ("UNKNOWN")]
			public static global::Com.Datadog.Android.Rum.Model.ActionEvent.Interface Unknown {
				get {
					const string __id = "UNKNOWN.Lcom/datadog/android/rum/model/ActionEvent$Interface;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.Interface> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Interface']/field[@name='WIFI']"
			[Register ("WIFI")]
			public static global::Com.Datadog.Android.Rum.Model.ActionEvent.Interface Wifi {
				get {
					const string __id = "WIFI.Lcom/datadog/android/rum/model/ActionEvent$Interface;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.Interface> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Interface']/field[@name='WIMAX']"
			[Register ("WIMAX")]
			public static global::Com.Datadog.Android.Rum.Model.ActionEvent.Interface Wimax {
				get {
					const string __id = "WIMAX.Lcom/datadog/android/rum/model/ActionEvent$Interface;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.Interface> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Interface.Companion']"
			[global::Android.Runtime.Register ("com/datadog/android/rum/model/ActionEvent$Interface$Companion", DoNotGenerateAcw=true)]
			public sealed partial class Companion : global::Java.Lang.Object {
				static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ActionEvent$Interface$Companion", typeof (Companion));

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

				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Interface.Companion']/constructor[@name='ActionEvent.Interface.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
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

				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Interface.Companion']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ActionEvent$Interface;", "")]
				public unsafe global::Com.Datadog.Android.Rum.Model.ActionEvent.Interface FromJson (string serializedObject)
				{
					const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ActionEvent$Interface;";
					IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_serializedObject);
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.Interface> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
						JNIEnv.DeleteLocalRef (native_serializedObject);
					}
				}

			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ActionEvent$Interface", typeof (Interface));

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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Interface']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ActionEvent$Interface;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ActionEvent.Interface FromJson (string serializedObject)
			{
				const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ActionEvent$Interface;";
				IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_serializedObject);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.Interface> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_serializedObject);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Interface']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ActionEvent$Interface;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ActionEvent.Interface ValueOf (string p0)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ActionEvent$Interface;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.Interface> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Interface']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/datadog/android/rum/model/ActionEvent$Interface;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ActionEvent.Interface[] Values ()
			{
				const string __id = "values.()[Lcom/datadog/android/rum/model/ActionEvent$Interface;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Datadog.Android.Rum.Model.ActionEvent.Interface[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Datadog.Android.Rum.Model.ActionEvent.Interface));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.LongTask']"
		[global::Android.Runtime.Register ("com/datadog/android/rum/model/ActionEvent$LongTask", DoNotGenerateAcw=true)]
		public sealed partial class LongTask : global::Java.Lang.Object {
			// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.LongTask.Companion']"
			[global::Android.Runtime.Register ("com/datadog/android/rum/model/ActionEvent$LongTask$Companion", DoNotGenerateAcw=true)]
			public sealed partial class Companion : global::Java.Lang.Object {
				static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ActionEvent$LongTask$Companion", typeof (Companion));

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

				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.LongTask.Companion']/constructor[@name='ActionEvent.LongTask.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
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

				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.LongTask.Companion']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ActionEvent$LongTask;", "")]
				public unsafe global::Com.Datadog.Android.Rum.Model.ActionEvent.LongTask FromJson (string serializedObject)
				{
					const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ActionEvent$LongTask;";
					IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_serializedObject);
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.LongTask> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
						JNIEnv.DeleteLocalRef (native_serializedObject);
					}
				}

			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ActionEvent$LongTask", typeof (LongTask));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.LongTask']/constructor[@name='ActionEvent.LongTask' and count(parameter)=1 and parameter[1][@type='long']]"
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
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.LongTask']/method[@name='getCount' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.LongTask']/method[@name='component1' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.LongTask']/method[@name='copy' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("copy", "(J)Lcom/datadog/android/rum/model/ActionEvent$LongTask;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ActionEvent.LongTask Copy (long count)
			{
				const string __id = "copy.(J)Lcom/datadog/android/rum/model/ActionEvent$LongTask;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (count);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.LongTask> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.LongTask']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ActionEvent$LongTask;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ActionEvent.LongTask FromJson (string serializedObject)
			{
				const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ActionEvent$LongTask;";
				IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_serializedObject);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.LongTask> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_serializedObject);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Resource']"
		[global::Android.Runtime.Register ("com/datadog/android/rum/model/ActionEvent$Resource", DoNotGenerateAcw=true)]
		public sealed partial class Resource : global::Java.Lang.Object {
			// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Resource.Companion']"
			[global::Android.Runtime.Register ("com/datadog/android/rum/model/ActionEvent$Resource$Companion", DoNotGenerateAcw=true)]
			public sealed partial class Companion : global::Java.Lang.Object {
				static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ActionEvent$Resource$Companion", typeof (Companion));

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

				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Resource.Companion']/constructor[@name='ActionEvent.Resource.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
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

				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Resource.Companion']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ActionEvent$Resource;", "")]
				public unsafe global::Com.Datadog.Android.Rum.Model.ActionEvent.Resource FromJson (string serializedObject)
				{
					const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ActionEvent$Resource;";
					IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_serializedObject);
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.Resource> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
						JNIEnv.DeleteLocalRef (native_serializedObject);
					}
				}

			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ActionEvent$Resource", typeof (Resource));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Resource']/constructor[@name='ActionEvent.Resource' and count(parameter)=1 and parameter[1][@type='long']]"
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
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Resource']/method[@name='getCount' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Resource']/method[@name='component1' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Resource']/method[@name='copy' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("copy", "(J)Lcom/datadog/android/rum/model/ActionEvent$Resource;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ActionEvent.Resource Copy (long count)
			{
				const string __id = "copy.(J)Lcom/datadog/android/rum/model/ActionEvent$Resource;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (count);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.Resource> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Resource']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ActionEvent$Resource;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ActionEvent.Resource FromJson (string serializedObject)
			{
				const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ActionEvent$Resource;";
				IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_serializedObject);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.Resource> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_serializedObject);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Session']"
		[global::Android.Runtime.Register ("com/datadog/android/rum/model/ActionEvent$Session", DoNotGenerateAcw=true)]
		public sealed partial class Session : global::Java.Lang.Object {
			// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Session.Companion']"
			[global::Android.Runtime.Register ("com/datadog/android/rum/model/ActionEvent$Session$Companion", DoNotGenerateAcw=true)]
			public sealed partial class Companion : global::Java.Lang.Object {
				static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ActionEvent$Session$Companion", typeof (Companion));

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

				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Session.Companion']/constructor[@name='ActionEvent.Session.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
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

				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Session.Companion']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ActionEvent$Session;", "")]
				public unsafe global::Com.Datadog.Android.Rum.Model.ActionEvent.Session FromJson (string serializedObject)
				{
					const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ActionEvent$Session;";
					IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_serializedObject);
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.Session> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
						JNIEnv.DeleteLocalRef (native_serializedObject);
					}
				}

			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ActionEvent$Session", typeof (Session));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Session']/constructor[@name='ActionEvent.Session' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.datadog.android.rum.model.ActionEvent.SessionType'] and parameter[3][@type='java.lang.Boolean']]"
			[Register (".ctor", "(Ljava/lang/String;Lcom/datadog/android/rum/model/ActionEvent$SessionType;Ljava/lang/Boolean;)V", "")]
			public unsafe Session (string id, global::Com.Datadog.Android.Rum.Model.ActionEvent.SessionType type, global::Java.Lang.Boolean hasReplay) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/String;Lcom/datadog/android/rum/model/ActionEvent$SessionType;Ljava/lang/Boolean;)V";

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
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Session']/method[@name='getHasReplay' and count(parameter)=0]"
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
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Session']/method[@name='getId' and count(parameter)=0]"
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

			public unsafe global::Com.Datadog.Android.Rum.Model.ActionEvent.SessionType Type {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Session']/method[@name='getType' and count(parameter)=0]"
				[Register ("getType", "()Lcom/datadog/android/rum/model/ActionEvent$SessionType;", "")]
				get {
					const string __id = "getType.()Lcom/datadog/android/rum/model/ActionEvent$SessionType;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.SessionType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Session']/method[@name='component1' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Session']/method[@name='component2' and count(parameter)=0]"
			[Register ("component2", "()Lcom/datadog/android/rum/model/ActionEvent$SessionType;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ActionEvent.SessionType Component2 ()
			{
				const string __id = "component2.()Lcom/datadog/android/rum/model/ActionEvent$SessionType;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.SessionType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Session']/method[@name='component3' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Session']/method[@name='copy' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.datadog.android.rum.model.ActionEvent.SessionType'] and parameter[3][@type='java.lang.Boolean']]"
			[Register ("copy", "(Ljava/lang/String;Lcom/datadog/android/rum/model/ActionEvent$SessionType;Ljava/lang/Boolean;)Lcom/datadog/android/rum/model/ActionEvent$Session;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ActionEvent.Session Copy (string id, global::Com.Datadog.Android.Rum.Model.ActionEvent.SessionType type, global::Java.Lang.Boolean hasReplay)
			{
				const string __id = "copy.(Ljava/lang/String;Lcom/datadog/android/rum/model/ActionEvent$SessionType;Ljava/lang/Boolean;)Lcom/datadog/android/rum/model/ActionEvent$Session;";
				IntPtr native_id = JNIEnv.NewString (id);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (native_id);
					__args [1] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
					__args [2] = new JniArgumentValue ((hasReplay == null) ? IntPtr.Zero : ((global::Java.Lang.Object) hasReplay).Handle);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.Session> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_id);
					global::System.GC.KeepAlive (type);
					global::System.GC.KeepAlive (hasReplay);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Session']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ActionEvent$Session;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ActionEvent.Session FromJson (string serializedObject)
			{
				const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ActionEvent$Session;";
				IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_serializedObject);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.Session> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_serializedObject);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.SessionType']"
		[global::Android.Runtime.Register ("com/datadog/android/rum/model/ActionEvent$SessionType", DoNotGenerateAcw=true)]
		public sealed partial class SessionType : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.SessionType']/field[@name='SYNTHETICS']"
			[Register ("SYNTHETICS")]
			public static global::Com.Datadog.Android.Rum.Model.ActionEvent.SessionType Synthetics {
				get {
					const string __id = "SYNTHETICS.Lcom/datadog/android/rum/model/ActionEvent$SessionType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.SessionType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.SessionType']/field[@name='USER']"
			[Register ("USER")]
			public static global::Com.Datadog.Android.Rum.Model.ActionEvent.SessionType User {
				get {
					const string __id = "USER.Lcom/datadog/android/rum/model/ActionEvent$SessionType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.SessionType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.SessionType.Companion']"
			[global::Android.Runtime.Register ("com/datadog/android/rum/model/ActionEvent$SessionType$Companion", DoNotGenerateAcw=true)]
			public sealed partial class Companion : global::Java.Lang.Object {
				static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ActionEvent$SessionType$Companion", typeof (Companion));

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

				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.SessionType.Companion']/constructor[@name='ActionEvent.SessionType.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
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

				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.SessionType.Companion']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ActionEvent$SessionType;", "")]
				public unsafe global::Com.Datadog.Android.Rum.Model.ActionEvent.SessionType FromJson (string serializedObject)
				{
					const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ActionEvent$SessionType;";
					IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_serializedObject);
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.SessionType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
						JNIEnv.DeleteLocalRef (native_serializedObject);
					}
				}

			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ActionEvent$SessionType", typeof (SessionType));

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

			internal SessionType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.SessionType']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ActionEvent$SessionType;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ActionEvent.SessionType FromJson (string serializedObject)
			{
				const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ActionEvent$SessionType;";
				IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_serializedObject);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.SessionType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_serializedObject);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.SessionType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ActionEvent$SessionType;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ActionEvent.SessionType ValueOf (string p0)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ActionEvent$SessionType;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.SessionType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.SessionType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/datadog/android/rum/model/ActionEvent$SessionType;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ActionEvent.SessionType[] Values ()
			{
				const string __id = "values.()[Lcom/datadog/android/rum/model/ActionEvent$SessionType;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Datadog.Android.Rum.Model.ActionEvent.SessionType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Datadog.Android.Rum.Model.ActionEvent.SessionType));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Status']"
		[global::Android.Runtime.Register ("com/datadog/android/rum/model/ActionEvent$Status", DoNotGenerateAcw=true)]
		public sealed partial class Status : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Status']/field[@name='CONNECTED']"
			[Register ("CONNECTED")]
			public static global::Com.Datadog.Android.Rum.Model.ActionEvent.Status Connected {
				get {
					const string __id = "CONNECTED.Lcom/datadog/android/rum/model/ActionEvent$Status;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.Status> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Status']/field[@name='MAYBE']"
			[Register ("MAYBE")]
			public static global::Com.Datadog.Android.Rum.Model.ActionEvent.Status Maybe {
				get {
					const string __id = "MAYBE.Lcom/datadog/android/rum/model/ActionEvent$Status;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.Status> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Status']/field[@name='NOT_CONNECTED']"
			[Register ("NOT_CONNECTED")]
			public static global::Com.Datadog.Android.Rum.Model.ActionEvent.Status NotConnected {
				get {
					const string __id = "NOT_CONNECTED.Lcom/datadog/android/rum/model/ActionEvent$Status;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.Status> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Status.Companion']"
			[global::Android.Runtime.Register ("com/datadog/android/rum/model/ActionEvent$Status$Companion", DoNotGenerateAcw=true)]
			public sealed partial class Companion : global::Java.Lang.Object {
				static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ActionEvent$Status$Companion", typeof (Companion));

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

				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Status.Companion']/constructor[@name='ActionEvent.Status.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
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

				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Status.Companion']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ActionEvent$Status;", "")]
				public unsafe global::Com.Datadog.Android.Rum.Model.ActionEvent.Status FromJson (string serializedObject)
				{
					const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ActionEvent$Status;";
					IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_serializedObject);
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.Status> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
						JNIEnv.DeleteLocalRef (native_serializedObject);
					}
				}

			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ActionEvent$Status", typeof (Status));

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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Status']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ActionEvent$Status;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ActionEvent.Status FromJson (string serializedObject)
			{
				const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ActionEvent$Status;";
				IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_serializedObject);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.Status> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_serializedObject);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Status']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ActionEvent$Status;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ActionEvent.Status ValueOf (string p0)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ActionEvent$Status;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.Status> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Status']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/datadog/android/rum/model/ActionEvent$Status;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ActionEvent.Status[] Values ()
			{
				const string __id = "values.()[Lcom/datadog/android/rum/model/ActionEvent$Status;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Datadog.Android.Rum.Model.ActionEvent.Status[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Datadog.Android.Rum.Model.ActionEvent.Status));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Target']"
		[global::Android.Runtime.Register ("com/datadog/android/rum/model/ActionEvent$Target", DoNotGenerateAcw=true)]
		public sealed partial class Target : global::Java.Lang.Object {
			// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Target.Companion']"
			[global::Android.Runtime.Register ("com/datadog/android/rum/model/ActionEvent$Target$Companion", DoNotGenerateAcw=true)]
			public sealed partial class Companion : global::Java.Lang.Object {
				static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ActionEvent$Target$Companion", typeof (Companion));

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

				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Target.Companion']/constructor[@name='ActionEvent.Target.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
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

				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Target.Companion']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ActionEvent$Target;", "")]
				public unsafe global::Com.Datadog.Android.Rum.Model.ActionEvent.Target FromJson (string serializedObject)
				{
					const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ActionEvent$Target;";
					IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_serializedObject);
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.Target> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
						JNIEnv.DeleteLocalRef (native_serializedObject);
					}
				}

			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ActionEvent$Target", typeof (Target));

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

			internal Target (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Target']/constructor[@name='ActionEvent.Target' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register (".ctor", "(Ljava/lang/String;)V", "")]
			public unsafe Target (string name) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/String;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			public unsafe string Name {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Target']/method[@name='getName' and count(parameter)=0]"
				[Register ("getName", "()Ljava/lang/String;", "")]
				get {
					const string __id = "getName.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Target']/method[@name='setName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setName", "(Ljava/lang/String;)V", "")]
				set {
					const string __id = "setName.(Ljava/lang/String;)V";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Target']/method[@name='component1' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Target']/method[@name='copy' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("copy", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ActionEvent$Target;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ActionEvent.Target Copy (string name)
			{
				const string __id = "copy.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ActionEvent$Target;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.Target> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Target']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ActionEvent$Target;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ActionEvent.Target FromJson (string serializedObject)
			{
				const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ActionEvent$Target;";
				IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_serializedObject);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.Target> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_serializedObject);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Usr']"
		[global::Android.Runtime.Register ("com/datadog/android/rum/model/ActionEvent$Usr", DoNotGenerateAcw=true)]
		public sealed partial class Usr : global::Java.Lang.Object {
			// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Usr.Companion']"
			[global::Android.Runtime.Register ("com/datadog/android/rum/model/ActionEvent$Usr$Companion", DoNotGenerateAcw=true)]
			public sealed partial class Companion : global::Java.Lang.Object {
				static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ActionEvent$Usr$Companion", typeof (Companion));

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

				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Usr.Companion']/constructor[@name='ActionEvent.Usr.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
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

				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Usr.Companion']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ActionEvent$Usr;", "")]
				public unsafe global::Com.Datadog.Android.Rum.Model.ActionEvent.Usr FromJson (string serializedObject)
				{
					const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ActionEvent$Usr;";
					IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_serializedObject);
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.Usr> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
						JNIEnv.DeleteLocalRef (native_serializedObject);
					}
				}

			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ActionEvent$Usr", typeof (Usr));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Usr']/constructor[@name='ActionEvent.Usr' and count(parameter)=0]"
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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Usr']/constructor[@name='ActionEvent.Usr' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
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
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Usr']/method[@name='getEmail' and count(parameter)=0]"
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
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Usr']/method[@name='getId' and count(parameter)=0]"
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
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Usr']/method[@name='getName' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Usr']/method[@name='component1' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Usr']/method[@name='component2' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Usr']/method[@name='component3' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Usr']/method[@name='copy' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
			[Register ("copy", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/datadog/android/rum/model/ActionEvent$Usr;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ActionEvent.Usr Copy (string id, string name, string email)
			{
				const string __id = "copy.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/datadog/android/rum/model/ActionEvent$Usr;";
				IntPtr native_id = JNIEnv.NewString (id);
				IntPtr native_name = JNIEnv.NewString (name);
				IntPtr native_email = JNIEnv.NewString (email);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (native_id);
					__args [1] = new JniArgumentValue (native_name);
					__args [2] = new JniArgumentValue (native_email);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.Usr> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_id);
					JNIEnv.DeleteLocalRef (native_name);
					JNIEnv.DeleteLocalRef (native_email);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.Usr']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ActionEvent$Usr;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ActionEvent.Usr FromJson (string serializedObject)
			{
				const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ActionEvent$Usr;";
				IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_serializedObject);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.Usr> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_serializedObject);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.View']"
		[global::Android.Runtime.Register ("com/datadog/android/rum/model/ActionEvent$View", DoNotGenerateAcw=true)]
		public sealed partial class View : global::Java.Lang.Object {
			// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.View.Companion']"
			[global::Android.Runtime.Register ("com/datadog/android/rum/model/ActionEvent$View$Companion", DoNotGenerateAcw=true)]
			public sealed partial class Companion : global::Java.Lang.Object {
				static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ActionEvent$View$Companion", typeof (Companion));

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

				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.View.Companion']/constructor[@name='ActionEvent.View.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
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

				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.View.Companion']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ActionEvent$View;", "")]
				public unsafe global::Com.Datadog.Android.Rum.Model.ActionEvent.View FromJson (string serializedObject)
				{
					const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ActionEvent$View;";
					IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_serializedObject);
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.View> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
						JNIEnv.DeleteLocalRef (native_serializedObject);
					}
				}

			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ActionEvent$View", typeof (View));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.View']/constructor[@name='ActionEvent.View' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
			[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
			public unsafe View (string id, string referrer, string url) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_id = JNIEnv.NewString (id);
				IntPtr native_referrer = JNIEnv.NewString (referrer);
				IntPtr native_url = JNIEnv.NewString (url);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (native_id);
					__args [1] = new JniArgumentValue (native_referrer);
					__args [2] = new JniArgumentValue (native_url);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_id);
					JNIEnv.DeleteLocalRef (native_referrer);
					JNIEnv.DeleteLocalRef (native_url);
				}
			}

			public unsafe string Id {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.View']/method[@name='getId' and count(parameter)=0]"
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

			public unsafe string Referrer {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.View']/method[@name='getReferrer' and count(parameter)=0]"
				[Register ("getReferrer", "()Ljava/lang/String;", "")]
				get {
					const string __id = "getReferrer.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.View']/method[@name='setReferrer' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

			public unsafe string Url {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.View']/method[@name='getUrl' and count(parameter)=0]"
				[Register ("getUrl", "()Ljava/lang/String;", "")]
				get {
					const string __id = "getUrl.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.View']/method[@name='setUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.View']/method[@name='component1' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.View']/method[@name='component2' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.View']/method[@name='component3' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.View']/method[@name='copy' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
			[Register ("copy", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/datadog/android/rum/model/ActionEvent$View;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ActionEvent.View Copy (string id, string referrer, string url)
			{
				const string __id = "copy.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/datadog/android/rum/model/ActionEvent$View;";
				IntPtr native_id = JNIEnv.NewString (id);
				IntPtr native_referrer = JNIEnv.NewString (referrer);
				IntPtr native_url = JNIEnv.NewString (url);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (native_id);
					__args [1] = new JniArgumentValue (native_referrer);
					__args [2] = new JniArgumentValue (native_url);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.View> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_id);
					JNIEnv.DeleteLocalRef (native_referrer);
					JNIEnv.DeleteLocalRef (native_url);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent.View']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ActionEvent$View;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ActionEvent.View FromJson (string serializedObject)
			{
				const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ActionEvent$View;";
				IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_serializedObject);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.View> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_serializedObject);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ActionEvent", typeof (ActionEvent));

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

		internal ActionEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent']/constructor[@name='ActionEvent' and count(parameter)=9 and parameter[1][@type='long'] and parameter[2][@type='com.datadog.android.rum.model.ActionEvent.Application'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.datadog.android.rum.model.ActionEvent.Session'] and parameter[5][@type='com.datadog.android.rum.model.ActionEvent.View'] and parameter[6][@type='com.datadog.android.rum.model.ActionEvent.Usr'] and parameter[7][@type='com.datadog.android.rum.model.ActionEvent.Connectivity'] and parameter[8][@type='com.datadog.android.rum.model.ActionEvent.Dd'] and parameter[9][@type='com.datadog.android.rum.model.ActionEvent.Action']]"
		[Register (".ctor", "(JLcom/datadog/android/rum/model/ActionEvent$Application;Ljava/lang/String;Lcom/datadog/android/rum/model/ActionEvent$Session;Lcom/datadog/android/rum/model/ActionEvent$View;Lcom/datadog/android/rum/model/ActionEvent$Usr;Lcom/datadog/android/rum/model/ActionEvent$Connectivity;Lcom/datadog/android/rum/model/ActionEvent$Dd;Lcom/datadog/android/rum/model/ActionEvent$Action;)V", "")]
		public unsafe ActionEvent (long date, global::Com.Datadog.Android.Rum.Model.ActionEvent.Application application, string service, global::Com.Datadog.Android.Rum.Model.ActionEvent.Session session, global::Com.Datadog.Android.Rum.Model.ActionEvent.View view, global::Com.Datadog.Android.Rum.Model.ActionEvent.Usr usr, global::Com.Datadog.Android.Rum.Model.ActionEvent.Connectivity connectivity, global::Com.Datadog.Android.Rum.Model.ActionEvent.Dd dd, global::Com.Datadog.Android.Rum.Model.ActionEvent.Action action) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(JLcom/datadog/android/rum/model/ActionEvent$Application;Ljava/lang/String;Lcom/datadog/android/rum/model/ActionEvent$Session;Lcom/datadog/android/rum/model/ActionEvent$View;Lcom/datadog/android/rum/model/ActionEvent$Usr;Lcom/datadog/android/rum/model/ActionEvent$Connectivity;Lcom/datadog/android/rum/model/ActionEvent$Dd;Lcom/datadog/android/rum/model/ActionEvent$Action;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_service = JNIEnv.NewString (service);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [9];
				__args [0] = new JniArgumentValue (date);
				__args [1] = new JniArgumentValue ((application == null) ? IntPtr.Zero : ((global::Java.Lang.Object) application).Handle);
				__args [2] = new JniArgumentValue (native_service);
				__args [3] = new JniArgumentValue ((session == null) ? IntPtr.Zero : ((global::Java.Lang.Object) session).Handle);
				__args [4] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [5] = new JniArgumentValue ((usr == null) ? IntPtr.Zero : ((global::Java.Lang.Object) usr).Handle);
				__args [6] = new JniArgumentValue ((connectivity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) connectivity).Handle);
				__args [7] = new JniArgumentValue ((dd == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dd).Handle);
				__args [8] = new JniArgumentValue ((action == null) ? IntPtr.Zero : ((global::Java.Lang.Object) action).Handle);
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
				global::System.GC.KeepAlive (action);
			}
		}

		public unsafe long Date {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent']/method[@name='getDate' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent']/method[@name='getService' and count(parameter)=0]"
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

		public unsafe string Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getType.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent']/method[@name='component1' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent']/method[@name='component2' and count(parameter)=0]"
		[Register ("component2", "()Lcom/datadog/android/rum/model/ActionEvent$Application;", "")]
		public unsafe global::Com.Datadog.Android.Rum.Model.ActionEvent.Application Component2 ()
		{
			const string __id = "component2.()Lcom/datadog/android/rum/model/ActionEvent$Application;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.Application> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent']/method[@name='component3' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent']/method[@name='component4' and count(parameter)=0]"
		[Register ("component4", "()Lcom/datadog/android/rum/model/ActionEvent$Session;", "")]
		public unsafe global::Com.Datadog.Android.Rum.Model.ActionEvent.Session Component4 ()
		{
			const string __id = "component4.()Lcom/datadog/android/rum/model/ActionEvent$Session;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.Session> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent']/method[@name='component5' and count(parameter)=0]"
		[Register ("component5", "()Lcom/datadog/android/rum/model/ActionEvent$View;", "")]
		public unsafe global::Com.Datadog.Android.Rum.Model.ActionEvent.View Component5 ()
		{
			const string __id = "component5.()Lcom/datadog/android/rum/model/ActionEvent$View;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.View> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent']/method[@name='component6' and count(parameter)=0]"
		[Register ("component6", "()Lcom/datadog/android/rum/model/ActionEvent$Usr;", "")]
		public unsafe global::Com.Datadog.Android.Rum.Model.ActionEvent.Usr Component6 ()
		{
			const string __id = "component6.()Lcom/datadog/android/rum/model/ActionEvent$Usr;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.Usr> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent']/method[@name='component7' and count(parameter)=0]"
		[Register ("component7", "()Lcom/datadog/android/rum/model/ActionEvent$Connectivity;", "")]
		public unsafe global::Com.Datadog.Android.Rum.Model.ActionEvent.Connectivity Component7 ()
		{
			const string __id = "component7.()Lcom/datadog/android/rum/model/ActionEvent$Connectivity;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.Connectivity> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent']/method[@name='component8' and count(parameter)=0]"
		[Register ("component8", "()Lcom/datadog/android/rum/model/ActionEvent$Dd;", "")]
		public unsafe global::Com.Datadog.Android.Rum.Model.ActionEvent.Dd Component8 ()
		{
			const string __id = "component8.()Lcom/datadog/android/rum/model/ActionEvent$Dd;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.Dd> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent']/method[@name='component9' and count(parameter)=0]"
		[Register ("component9", "()Lcom/datadog/android/rum/model/ActionEvent$Action;", "")]
		public unsafe global::Com.Datadog.Android.Rum.Model.ActionEvent.Action Component9 ()
		{
			const string __id = "component9.()Lcom/datadog/android/rum/model/ActionEvent$Action;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.Action> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent']/method[@name='copy' and count(parameter)=9 and parameter[1][@type='long'] and parameter[2][@type='com.datadog.android.rum.model.ActionEvent.Application'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.datadog.android.rum.model.ActionEvent.Session'] and parameter[5][@type='com.datadog.android.rum.model.ActionEvent.View'] and parameter[6][@type='com.datadog.android.rum.model.ActionEvent.Usr'] and parameter[7][@type='com.datadog.android.rum.model.ActionEvent.Connectivity'] and parameter[8][@type='com.datadog.android.rum.model.ActionEvent.Dd'] and parameter[9][@type='com.datadog.android.rum.model.ActionEvent.Action']]"
		[Register ("copy", "(JLcom/datadog/android/rum/model/ActionEvent$Application;Ljava/lang/String;Lcom/datadog/android/rum/model/ActionEvent$Session;Lcom/datadog/android/rum/model/ActionEvent$View;Lcom/datadog/android/rum/model/ActionEvent$Usr;Lcom/datadog/android/rum/model/ActionEvent$Connectivity;Lcom/datadog/android/rum/model/ActionEvent$Dd;Lcom/datadog/android/rum/model/ActionEvent$Action;)Lcom/datadog/android/rum/model/ActionEvent;", "")]
		public unsafe global::Com.Datadog.Android.Rum.Model.ActionEvent Copy (long date, global::Com.Datadog.Android.Rum.Model.ActionEvent.Application application, string service, global::Com.Datadog.Android.Rum.Model.ActionEvent.Session session, global::Com.Datadog.Android.Rum.Model.ActionEvent.View view, global::Com.Datadog.Android.Rum.Model.ActionEvent.Usr usr, global::Com.Datadog.Android.Rum.Model.ActionEvent.Connectivity connectivity, global::Com.Datadog.Android.Rum.Model.ActionEvent.Dd dd, global::Com.Datadog.Android.Rum.Model.ActionEvent.Action action)
		{
			const string __id = "copy.(JLcom/datadog/android/rum/model/ActionEvent$Application;Ljava/lang/String;Lcom/datadog/android/rum/model/ActionEvent$Session;Lcom/datadog/android/rum/model/ActionEvent$View;Lcom/datadog/android/rum/model/ActionEvent$Usr;Lcom/datadog/android/rum/model/ActionEvent$Connectivity;Lcom/datadog/android/rum/model/ActionEvent$Dd;Lcom/datadog/android/rum/model/ActionEvent$Action;)Lcom/datadog/android/rum/model/ActionEvent;";
			IntPtr native_service = JNIEnv.NewString (service);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [9];
				__args [0] = new JniArgumentValue (date);
				__args [1] = new JniArgumentValue ((application == null) ? IntPtr.Zero : ((global::Java.Lang.Object) application).Handle);
				__args [2] = new JniArgumentValue (native_service);
				__args [3] = new JniArgumentValue ((session == null) ? IntPtr.Zero : ((global::Java.Lang.Object) session).Handle);
				__args [4] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [5] = new JniArgumentValue ((usr == null) ? IntPtr.Zero : ((global::Java.Lang.Object) usr).Handle);
				__args [6] = new JniArgumentValue ((connectivity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) connectivity).Handle);
				__args [7] = new JniArgumentValue ((dd == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dd).Handle);
				__args [8] = new JniArgumentValue ((action == null) ? IntPtr.Zero : ((global::Java.Lang.Object) action).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_service);
				global::System.GC.KeepAlive (application);
				global::System.GC.KeepAlive (session);
				global::System.GC.KeepAlive (view);
				global::System.GC.KeepAlive (usr);
				global::System.GC.KeepAlive (connectivity);
				global::System.GC.KeepAlive (dd);
				global::System.GC.KeepAlive (action);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ActionEvent;", "")]
		public static unsafe global::Com.Datadog.Android.Rum.Model.ActionEvent FromJson (string serializedObject)
		{
			const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ActionEvent;";
			IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_serializedObject);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_serializedObject);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent']/method[@name='getAction' and count(parameter)=0]"
		[Register ("getAction", "()Lcom/datadog/android/rum/model/ActionEvent$Action;", "")]
		public unsafe global::Com.Datadog.Android.Rum.Model.ActionEvent.Action GetAction ()
		{
			const string __id = "getAction.()Lcom/datadog/android/rum/model/ActionEvent$Action;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.Action> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent']/method[@name='getApplication' and count(parameter)=0]"
		[Register ("getApplication", "()Lcom/datadog/android/rum/model/ActionEvent$Application;", "")]
		public unsafe global::Com.Datadog.Android.Rum.Model.ActionEvent.Application GetApplication ()
		{
			const string __id = "getApplication.()Lcom/datadog/android/rum/model/ActionEvent$Application;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.Application> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent']/method[@name='getConnectivity' and count(parameter)=0]"
		[Register ("getConnectivity", "()Lcom/datadog/android/rum/model/ActionEvent$Connectivity;", "")]
		public unsafe global::Com.Datadog.Android.Rum.Model.ActionEvent.Connectivity GetConnectivity ()
		{
			const string __id = "getConnectivity.()Lcom/datadog/android/rum/model/ActionEvent$Connectivity;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.Connectivity> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent']/method[@name='getDd' and count(parameter)=0]"
		[Register ("getDd", "()Lcom/datadog/android/rum/model/ActionEvent$Dd;", "")]
		public unsafe global::Com.Datadog.Android.Rum.Model.ActionEvent.Dd GetDd ()
		{
			const string __id = "getDd.()Lcom/datadog/android/rum/model/ActionEvent$Dd;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.Dd> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent']/method[@name='getSession' and count(parameter)=0]"
		[Register ("getSession", "()Lcom/datadog/android/rum/model/ActionEvent$Session;", "")]
		public unsafe global::Com.Datadog.Android.Rum.Model.ActionEvent.Session GetSession ()
		{
			const string __id = "getSession.()Lcom/datadog/android/rum/model/ActionEvent$Session;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.Session> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent']/method[@name='getUsr' and count(parameter)=0]"
		[Register ("getUsr", "()Lcom/datadog/android/rum/model/ActionEvent$Usr;", "")]
		public unsafe global::Com.Datadog.Android.Rum.Model.ActionEvent.Usr GetUsr ()
		{
			const string __id = "getUsr.()Lcom/datadog/android/rum/model/ActionEvent$Usr;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.Usr> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ActionEvent']/method[@name='getView' and count(parameter)=0]"
		[Register ("getView", "()Lcom/datadog/android/rum/model/ActionEvent$View;", "")]
		public unsafe global::Com.Datadog.Android.Rum.Model.ActionEvent.View GetView ()
		{
			const string __id = "getView.()Lcom/datadog/android/rum/model/ActionEvent$View;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ActionEvent.View> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
