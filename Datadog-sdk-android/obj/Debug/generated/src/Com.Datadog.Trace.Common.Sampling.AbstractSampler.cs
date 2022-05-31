using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Datadog.Trace.Common.Sampling {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.trace.common.sampling']/class[@name='AbstractSampler']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[global::Android.Runtime.Register ("com/datadog/trace/common/sampling/AbstractSampler", DoNotGenerateAcw=true)]
	public abstract partial class AbstractSampler : global::Java.Lang.Object, global::Com.Datadog.Trace.Common.Sampling.ISampler {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.common.sampling']/class[@name='AbstractSampler']/field[@name='skipTagsPatterns']"
		[Register ("skipTagsPatterns")]
		protected global::System.Collections.IDictionary SkipTagsPatterns {
			get {
				const string __id = "skipTagsPatterns.Ljava/util/Map;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "skipTagsPatterns.Ljava/util/Map;";

				IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/trace/common/sampling/AbstractSampler", typeof (AbstractSampler));

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

		protected AbstractSampler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.trace.common.sampling']/class[@name='AbstractSampler']/constructor[@name='AbstractSampler' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AbstractSampler () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_addSkipTagPattern_Ljava_lang_String_Ljava_util_regex_Pattern_;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetAddSkipTagPattern_Ljava_lang_String_Ljava_util_regex_Pattern_Handler ()
		{
			if (cb_addSkipTagPattern_Ljava_lang_String_Ljava_util_regex_Pattern_ == null)
				cb_addSkipTagPattern_Ljava_lang_String_Ljava_util_regex_Pattern_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_AddSkipTagPattern_Ljava_lang_String_Ljava_util_regex_Pattern_);
			return cb_addSkipTagPattern_Ljava_lang_String_Ljava_util_regex_Pattern_;
		}

		[Obsolete]
		static void n_AddSkipTagPattern_Ljava_lang_String_Ljava_util_regex_Pattern_ (IntPtr jnienv, IntPtr native__this, IntPtr native_tag, IntPtr native_skipPattern)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Common.Sampling.AbstractSampler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var tag = JNIEnv.GetString (native_tag, JniHandleOwnership.DoNotTransfer);
			var skipPattern = global::Java.Lang.Object.GetObject<global::Java.Util.Regex.Pattern> (native_skipPattern, JniHandleOwnership.DoNotTransfer);
			__this.AddSkipTagPattern (tag, skipPattern);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.common.sampling']/class[@name='AbstractSampler']/method[@name='addSkipTagPattern' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.regex.Pattern']]"
		[Obsolete (@"deprecated")]
		[Register ("addSkipTagPattern", "(Ljava/lang/String;Ljava/util/regex/Pattern;)V", "GetAddSkipTagPattern_Ljava_lang_String_Ljava_util_regex_Pattern_Handler")]
		public virtual unsafe void AddSkipTagPattern (string tag, global::Java.Util.Regex.Pattern skipPattern)
		{
			const string __id = "addSkipTagPattern.(Ljava/lang/String;Ljava/util/regex/Pattern;)V";
			IntPtr native_tag = JNIEnv.NewString (tag);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_tag);
				__args [1] = new JniArgumentValue ((skipPattern == null) ? IntPtr.Zero : ((global::Java.Lang.Object) skipPattern).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				global::System.GC.KeepAlive (skipPattern);
			}
		}

	}

	[global::Android.Runtime.Register ("com/datadog/trace/common/sampling/AbstractSampler", DoNotGenerateAcw=true)]
	internal partial class AbstractSamplerInvoker : AbstractSampler {
		public AbstractSamplerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/trace/common/sampling/AbstractSampler", typeof (AbstractSamplerInvoker));

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
