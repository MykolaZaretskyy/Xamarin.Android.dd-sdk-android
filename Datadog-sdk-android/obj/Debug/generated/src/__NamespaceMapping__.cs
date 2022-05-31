using System;

[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.datadog.android", Managed="Com.Datadog.Android")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.datadog.android.core.configuration", Managed="Com.Datadog.Android.Core.Configuration")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.datadog.android.core.internal.constraints", Managed="Com.Datadog.Android.Core.Internal.Constraints")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.datadog.android.core.internal.data.file", Managed="Com.Datadog.Android.Core.Internal.Data.File")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.datadog.android.core.internal.domain", Managed="Com.Datadog.Android.Core.Internal.Domain")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.datadog.android.core.internal.net", Managed="Com.Datadog.Android.Core.Internal.Net")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.datadog.android.core.internal.utils", Managed="Com.Datadog.Android.Core.Internal.Utils")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.datadog.android.event", Managed="Com.Datadog.Android.Event")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.datadog.android.log", Managed="Com.Datadog.Android.Log")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.datadog.android.plugin", Managed="Com.Datadog.Android.Plugin")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.datadog.android.privacy", Managed="Com.Datadog.Android.Privacy")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.datadog.android.rum", Managed="Com.Datadog.Android.Rum")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.datadog.android.rum.internal.domain.event", Managed="Com.Datadog.Android.Rum.Internal.Domain.Event")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.datadog.android.rum.internal.domain.scope", Managed="Com.Datadog.Android.Rum.Internal.Domain.Scope")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.datadog.android.rum.internal.instrumentation.gestures", Managed="Com.Datadog.Android.Rum.Internal.Instrumentation.Gestures")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.datadog.android.rum.model", Managed="Com.Datadog.Android.Rum.Model")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.datadog.android.rum.resource", Managed="Com.Datadog.Android.Rum.Resource")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.datadog.android.rum.tracking", Managed="Com.Datadog.Android.Rum.Tracking")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.datadog.android.rum.webview", Managed="Com.Datadog.Android.Rum.Webview")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.datadog.android.sqlite", Managed="Com.Datadog.Android.Sqlite")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.datadog.android.tracing", Managed="Com.Datadog.Android.Tracing")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.datadog.android.tracing.internal.utils", Managed="Com.Datadog.Android.Tracing.Internal.Utils")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.datadog.exec", Managed="Com.Datadog.Exec")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.datadog.opentracing", Managed="Com.Datadog.Opentracing")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.datadog.opentracing.decorators", Managed="Com.Datadog.Opentracing.Decorators")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.datadog.opentracing.jfr", Managed="Com.Datadog.Opentracing.Jfr")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.datadog.opentracing.propagation", Managed="Com.Datadog.Opentracing.Propagation")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.datadog.tools.annotation", Managed="Com.Datadog.Tools.Annotation")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.datadog.trace.api", Managed="Com.Datadog.Trace.Api")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.datadog.trace.api.interceptor", Managed="Com.Datadog.Trace.Api.Interceptor")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.datadog.trace.api.sampling", Managed="Com.Datadog.Trace.Api.Sampling")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.datadog.trace.common.sampling", Managed="Com.Datadog.Trace.Common.Sampling")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.datadog.trace.common.util", Managed="Com.Datadog.Trace.Common.Util")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.datadog.trace.common.writer", Managed="Com.Datadog.Trace.Common.Writer")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.datadog.trace.context", Managed="Com.Datadog.Trace.Context")]

delegate double _JniMarshal_PP_D (IntPtr jnienv, IntPtr klass);
delegate int _JniMarshal_PP_I (IntPtr jnienv, IntPtr klass);
delegate long _JniMarshal_PP_J (IntPtr jnienv, IntPtr klass);
delegate IntPtr _JniMarshal_PP_L (IntPtr jnienv, IntPtr klass);
delegate void _JniMarshal_PP_V (IntPtr jnienv, IntPtr klass);
delegate bool _JniMarshal_PP_Z (IntPtr jnienv, IntPtr klass);
delegate IntPtr _JniMarshal_PPI_L (IntPtr jnienv, IntPtr klass, int p0);
delegate float _JniMarshal_PPL_F (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate IntPtr _JniMarshal_PPL_L (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate void _JniMarshal_PPL_V (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate bool _JniMarshal_PPL_Z (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate IntPtr _JniMarshal_PPLL_L (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1);
delegate void _JniMarshal_PPLL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1);
delegate void _JniMarshal_PPLLL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2);
delegate void _JniMarshal_PPLLLL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2, IntPtr p3);
delegate void _JniMarshal_PPLLLLL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2, IntPtr p3, IntPtr p4);
delegate IntPtr _JniMarshal_PPLZ_L (IntPtr jnienv, IntPtr klass, IntPtr p0, bool p1);
delegate bool _JniMarshal_PPLZ_Z (IntPtr jnienv, IntPtr klass, IntPtr p0, bool p1);
delegate IntPtr _JniMarshal_PPZ_L (IntPtr jnienv, IntPtr klass, bool p0);
delegate void _JniMarshal_PPZ_V (IntPtr jnienv, IntPtr klass, bool p0);
#if !NET
namespace System.Runtime.Versioning {
    [System.Diagnostics.Conditional("NEVER")]
    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Constructor | AttributeTargets.Event | AttributeTargets.Method | AttributeTargets.Module | AttributeTargets.Property | AttributeTargets.Struct, AllowMultiple = true, Inherited = false)]
    internal sealed class SupportedOSPlatformAttribute : Attribute {
        public SupportedOSPlatformAttribute (string platformName) { }
    }
}
#endif

