using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Datadog.Opentracing.Decorators {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.opentracing.decorators']/class[@name='AbstractDecorator']"
	[global::Android.Runtime.Register ("com/datadog/opentracing/decorators/AbstractDecorator", DoNotGenerateAcw=true)]
	public abstract partial class AbstractDecorator : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/opentracing/decorators/AbstractDecorator", typeof (AbstractDecorator));

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

		protected AbstractDecorator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.opentracing.decorators']/class[@name='AbstractDecorator']/constructor[@name='AbstractDecorator' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AbstractDecorator () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_getMatchingTag;
#pragma warning disable 0169
		static Delegate GetGetMatchingTagHandler ()
		{
			if (cb_getMatchingTag == null)
				cb_getMatchingTag = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetMatchingTag);
			return cb_getMatchingTag;
		}

		static IntPtr n_GetMatchingTag (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Opentracing.Decorators.AbstractDecorator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MatchingTag);
		}
#pragma warning restore 0169

		static Delegate cb_setMatchingTag_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMatchingTag_Ljava_lang_String_Handler ()
		{
			if (cb_setMatchingTag_Ljava_lang_String_ == null)
				cb_setMatchingTag_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetMatchingTag_Ljava_lang_String_);
			return cb_setMatchingTag_Ljava_lang_String_;
		}

		static void n_SetMatchingTag_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_tag)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Opentracing.Decorators.AbstractDecorator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var tag = JNIEnv.GetString (native_tag, JniHandleOwnership.DoNotTransfer);
			__this.MatchingTag = tag;
		}
#pragma warning restore 0169

		public virtual unsafe string MatchingTag {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.opentracing.decorators']/class[@name='AbstractDecorator']/method[@name='getMatchingTag' and count(parameter)=0]"
			[Register ("getMatchingTag", "()Ljava/lang/String;", "GetGetMatchingTagHandler")]
			get {
				const string __id = "getMatchingTag.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.opentracing.decorators']/class[@name='AbstractDecorator']/method[@name='setMatchingTag' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setMatchingTag", "(Ljava/lang/String;)V", "GetSetMatchingTag_Ljava_lang_String_Handler")]
			set {
				const string __id = "setMatchingTag.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getMatchingValue;
#pragma warning disable 0169
		static Delegate GetGetMatchingValueHandler ()
		{
			if (cb_getMatchingValue == null)
				cb_getMatchingValue = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetMatchingValue);
			return cb_getMatchingValue;
		}

		static IntPtr n_GetMatchingValue (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Opentracing.Decorators.AbstractDecorator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MatchingValue);
		}
#pragma warning restore 0169

		static Delegate cb_setMatchingValue_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSetMatchingValue_Ljava_lang_Object_Handler ()
		{
			if (cb_setMatchingValue_Ljava_lang_Object_ == null)
				cb_setMatchingValue_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetMatchingValue_Ljava_lang_Object_);
			return cb_setMatchingValue_Ljava_lang_Object_;
		}

		static void n_SetMatchingValue_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Opentracing.Decorators.AbstractDecorator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var value = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.MatchingValue = value;
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Object MatchingValue {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.opentracing.decorators']/class[@name='AbstractDecorator']/method[@name='getMatchingValue' and count(parameter)=0]"
			[Register ("getMatchingValue", "()Ljava/lang/Object;", "GetGetMatchingValueHandler")]
			get {
				const string __id = "getMatchingValue.()Ljava/lang/Object;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.opentracing.decorators']/class[@name='AbstractDecorator']/method[@name='setMatchingValue' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
			[Register ("setMatchingValue", "(Ljava/lang/Object;)V", "GetSetMatchingValue_Ljava_lang_Object_Handler")]
			set {
				const string __id = "setMatchingValue.(Ljava/lang/Object;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_getReplacementTag;
#pragma warning disable 0169
		static Delegate GetGetReplacementTagHandler ()
		{
			if (cb_getReplacementTag == null)
				cb_getReplacementTag = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetReplacementTag);
			return cb_getReplacementTag;
		}

		static IntPtr n_GetReplacementTag (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Opentracing.Decorators.AbstractDecorator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ReplacementTag);
		}
#pragma warning restore 0169

		static Delegate cb_setReplacementTag_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetReplacementTag_Ljava_lang_String_Handler ()
		{
			if (cb_setReplacementTag_Ljava_lang_String_ == null)
				cb_setReplacementTag_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetReplacementTag_Ljava_lang_String_);
			return cb_setReplacementTag_Ljava_lang_String_;
		}

		static void n_SetReplacementTag_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_targetTag)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Opentracing.Decorators.AbstractDecorator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var targetTag = JNIEnv.GetString (native_targetTag, JniHandleOwnership.DoNotTransfer);
			__this.ReplacementTag = targetTag;
		}
#pragma warning restore 0169

		public virtual unsafe string ReplacementTag {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.opentracing.decorators']/class[@name='AbstractDecorator']/method[@name='getReplacementTag' and count(parameter)=0]"
			[Register ("getReplacementTag", "()Ljava/lang/String;", "GetGetReplacementTagHandler")]
			get {
				const string __id = "getReplacementTag.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.opentracing.decorators']/class[@name='AbstractDecorator']/method[@name='setReplacementTag' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setReplacementTag", "(Ljava/lang/String;)V", "GetSetReplacementTag_Ljava_lang_String_Handler")]
			set {
				const string __id = "setReplacementTag.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getReplacementValue;
#pragma warning disable 0169
		static Delegate GetGetReplacementValueHandler ()
		{
			if (cb_getReplacementValue == null)
				cb_getReplacementValue = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetReplacementValue);
			return cb_getReplacementValue;
		}

		static IntPtr n_GetReplacementValue (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Opentracing.Decorators.AbstractDecorator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ReplacementValue);
		}
#pragma warning restore 0169

		static Delegate cb_setReplacementValue_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetReplacementValue_Ljava_lang_String_Handler ()
		{
			if (cb_setReplacementValue_Ljava_lang_String_ == null)
				cb_setReplacementValue_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetReplacementValue_Ljava_lang_String_);
			return cb_setReplacementValue_Ljava_lang_String_;
		}

		static void n_SetReplacementValue_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_targetValue)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Opentracing.Decorators.AbstractDecorator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var targetValue = JNIEnv.GetString (native_targetValue, JniHandleOwnership.DoNotTransfer);
			__this.ReplacementValue = targetValue;
		}
#pragma warning restore 0169

		public virtual unsafe string ReplacementValue {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.opentracing.decorators']/class[@name='AbstractDecorator']/method[@name='getReplacementValue' and count(parameter)=0]"
			[Register ("getReplacementValue", "()Ljava/lang/String;", "GetGetReplacementValueHandler")]
			get {
				const string __id = "getReplacementValue.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.opentracing.decorators']/class[@name='AbstractDecorator']/method[@name='setReplacementValue' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setReplacementValue", "(Ljava/lang/String;)V", "GetSetReplacementValue_Ljava_lang_String_Handler")]
			set {
				const string __id = "setReplacementValue.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

	}

	[global::Android.Runtime.Register ("com/datadog/opentracing/decorators/AbstractDecorator", DoNotGenerateAcw=true)]
	internal partial class AbstractDecoratorInvoker : AbstractDecorator {
		public AbstractDecoratorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/opentracing/decorators/AbstractDecorator", typeof (AbstractDecoratorInvoker));

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

	}
}
