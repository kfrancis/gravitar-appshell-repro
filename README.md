# gravitar-appshell-repro

## What does this issue look like
<img src="https://github.com/kfrancis/gravitar-appshell-repro/blob/7874f6b7e01bcb1ee3a213e19d325f87800de885/repro.gif" />

Notes:

- I'm generating a "random" email just so I can use the `GravitarImageSource` and specify `RoboHash`, so you can see it's not working right from the start
- When I navigate to this in debug, I get the following exception:

```
Android.Util.AndroidRuntimeException
  Message=Only the original thread that created a view hierarchy can touch its views.

 	0xFFFFFFFFFFFFFFFF in Android.Runtime.JNIEnv.monodroid_debugger_unhandled_exception	C#
 	0x1A in Android.Runtime.JNINativeWrapper._unhandled_exception at /Users/runner/work/1/s/xamarin-android/src/Mono.Android/Android.Runtime/JNINativeWrapper.g.cs:12,5	C#
 	0x1D in Android.Runtime.JNINativeWrapper.Wrap_JniMarshal_PP_V at /Users/runner/work/1/s/xamarin-android/src/Mono.Android/Android.Runtime/JNINativeWrapper.g.cs:23,26	C#
 	0x17 in System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw	C#
 	0x89 in Java.Interop.JniEnvironment.InstanceMethods.CallNonvirtualVoidMethod at /Users/runner/work/1/s/xamarin-android/external/Java.Interop/src/Java.Interop/obj/Release/net7.0/JniEnvironment.g.cs:12324,5	C#
 	0x78 in Java.Interop.JniPeerMembers.JniInstanceMethods.InvokeVirtualVoidMethod at /Users/runner/work/1/s/xamarin-android/external/Java.Interop/src/Java.Interop/Java.Interop/JniPeerMembers.JniInstanceMethods_Invoke.cs:75,7	C#
 	0x12 in Android.Views.View.RequestLayout at /Users/runner/work/1/s/xamarin-android/src/Mono.Android/obj/Release/net7.0/android-33/mcw/Android.Views.View.cs:20879,5	C#
 	0x8 in Microsoft.Maui.Platform.WrapperView.RequestLayout at D:\a\_work\1\s\src\Core\src\Platform\Android\WrapperView.cs:89,4	C#
 	0x8 in Android.Views.View.n_RequestLayout at /Users/runner/work/1/s/xamarin-android/src/Mono.Android/obj/Release/net7.0/android-33/mcw/Android.Views.View.cs:20869,4	C#
 	0x8 in Android.Runtime.JNINativeWrapper.Wrap_JniMarshal_PP_V at /Users/runner/work/1/s/xamarin-android/src/Mono.Android/Android.Runtime/JNINativeWrapper.g.cs:22,5	C#
 	0x37 in Java.Interop.NativeMethods.java_interop_jnienv_call_static_void_method_a	C#
 	0x54 in Java.Interop.JniEnvironment.StaticMethods.CallStaticVoidMethod at /Users/runner/work/1/s/xamarin-android/external/Java.Interop/src/Java.Interop/obj/Release/net7.0/JniEnvironment.g.cs:13246,4	C#
 	0x1A in Java.Interop.JniPeerMembers.JniStaticMethods.InvokeVoidMethod at /Users/runner/work/1/s/xamarin-android/external/Java.Interop/src/Java.Interop/Java.Interop/JniPeerMembers.JniStaticMethods.cs:97,4	C#
 	0x7B in Microsoft.Maui.PlatformInterop.LoadImageFromStream at D:\a\_work\1\s\src\Core\src\obj\Release\net7.0-android\generated\src\Microsoft.Maui.PlatformInterop.cs:443,5	C#
 	0xC8 in Microsoft.Maui.StreamImageSourceService.LoadDrawableAsync at D:\a\_work\1\s\src\Core\src\ImageSources\StreamImageSourceService\StreamImageSourceService.Android.cs:28,6	C#
 	0x11 in System.Runtime.CompilerServices.AsyncTaskMethodBuilder<Microsoft.Maui.IImageSourceServiceResult>.AsyncStateMachineBox<Microsoft.Maui.StreamImageSourceService.<LoadDrawableAsync>d__0>.ExecutionContextCallback	C#
 	0x17 in System.Threading.ExecutionContext.RunFromThreadPoolDispatchLoop	C#
 	0x55 in System.Runtime.CompilerServices.AsyncTaskMethodBuilder<Microsoft.Maui.IImageSourceServiceResult>.AsyncStateMachineBox<Microsoft.Maui.StreamImageSourceService.<LoadDrawableAsync>d__0>.MoveNext	C#
 	0x2 in System.Runtime.CompilerServices.AsyncTaskMethodBuilder<Microsoft.Maui.IImageSourceServiceResult>.AsyncStateMachineBox<Microsoft.Maui.StreamImageSourceService.<LoadDrawableAsync>d__0>.ExecuteFromThreadPool	C#
 	0xC in System.Threading.ThreadPoolWorkQueue.DispatchWorkItem	C#
 	0x142 in System.Threading.ThreadPoolWorkQueue.Dispatch	C#
 	0x67 in System.Threading.PortableThreadPool.WorkerThread.WorkerThreadStart	C#
 	0x1F in System.Threading.Thread.StartHelper.RunWorker	C#
 	0x28 in System.Threading.Thread.StartHelper.Run	C#
 	0xF in System.Threading.Thread.StartCallback	C#

```

- Suspending the app and navigating back seems to restore function, but it's a workaround.
