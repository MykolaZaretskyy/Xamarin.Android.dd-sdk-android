using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Java.Interop {

	partial class __TypeRegistrations {

		public static void RegisterPackages ()
		{
#if MONODROID_TIMING
			var start = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages start: " + (start - new DateTime (1970, 1, 1)).TotalMilliseconds);
#endif // def MONODROID_TIMING
			Java.Interop.TypeManager.RegisterPackages (
					new string[]{
						"com/datadog/android/rum",
						"com/datadog/trace/common/sampling",
					},
					new Converter<string, Type>[]{
						lookup_com_datadog_android_rum_package,
						lookup_com_datadog_trace_common_sampling_package,
					});
#if MONODROID_TIMING
			var end = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages time: " + (end - new DateTime (1970, 1, 1)).TotalMilliseconds + " [elapsed: " + (end - start).TotalMilliseconds + " ms]");
#endif // def MONODROID_TIMING
		}

#if NET5_0_OR_GREATER
		[System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage ("Trimming", "IL2057")]
#endif
		static Type Lookup (string[] mappings, string javaType)
		{
			var managedType = Java.Interop.TypeManager.LookupTypeMapping (mappings, javaType);
			if (managedType == null)
				return null;
			return Type.GetType (managedType);
		}

		static string[] package_com_datadog_android_rum_mappings;
		static Type lookup_com_datadog_android_rum_package (string klass)
		{
			if (package_com_datadog_android_rum_mappings == null) {
				package_com_datadog_android_rum_mappings = new string[]{
					"com/datadog/android/rum/RumMonitor$Builder:Com.Datadog.Android.Rum.RumMonitorBuilder",
					"com/datadog/android/rum/RumMonitor$Builder$Companion:Com.Datadog.Android.Rum.RumMonitorBuilder/Companion",
					"com/datadog/android/rum/RumMonitor$DefaultImpls:Com.Datadog.Android.Rum.RumMonitorDefaultImpls",
				};
			}

			return Lookup (package_com_datadog_android_rum_mappings, klass);
		}

		static string[] package_com_datadog_trace_common_sampling_mappings;
		static Type lookup_com_datadog_trace_common_sampling_package (string klass)
		{
			if (package_com_datadog_trace_common_sampling_mappings == null) {
				package_com_datadog_trace_common_sampling_mappings = new string[]{
					"com/datadog/trace/common/sampling/Sampler$Builder:Com.Datadog.Trace.Common.Sampling.SamplerBuilder",
				};
			}

			return Lookup (package_com_datadog_trace_common_sampling_mappings, klass);
		}
	}
}
