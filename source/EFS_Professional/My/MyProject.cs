namespace EFS_Professional.My
{
    using EFS_Professional;
    using Microsoft.VisualBasic;
    using Microsoft.VisualBasic.ApplicationServices;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.CodeDom.Compiler;
    using System.Collections;
    using System.ComponentModel;
    using System.ComponentModel.Design;
    using System.Diagnostics;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    [StandardModule, GeneratedCode("MyTemplate", "11.0.0.0"), HideModuleName]
    internal sealed class MyProject
    {
        private static readonly ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider = new ThreadSafeObjectProvider<MyApplication>();
        private static readonly ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider = new ThreadSafeObjectProvider<MyComputer>();
        private static ThreadSafeObjectProvider<MyForms> m_MyFormsObjectProvider = new ThreadSafeObjectProvider<MyForms>();
        private static readonly ThreadSafeObjectProvider<MyWebServices> m_MyWebServicesObjectProvider = new ThreadSafeObjectProvider<MyWebServices>();
        private static readonly ThreadSafeObjectProvider<Microsoft.VisualBasic.ApplicationServices.User> m_UserObjectProvider = new ThreadSafeObjectProvider<Microsoft.VisualBasic.ApplicationServices.User>();

        [HelpKeyword("My.Application")]
        internal static MyApplication Application =>
            m_AppObjectProvider.GetInstance;

        [HelpKeyword("My.Computer")]
        internal static MyComputer Computer =>
            m_ComputerObjectProvider.GetInstance;

        [HelpKeyword("My.Forms")]
        internal static MyForms Forms =>
            m_MyFormsObjectProvider.GetInstance;

        [HelpKeyword("My.User")]
        internal static Microsoft.VisualBasic.ApplicationServices.User User =>
            m_UserObjectProvider.GetInstance;

        [HelpKeyword("My.WebServices")]
        internal static MyWebServices WebServices =>
            m_MyWebServicesObjectProvider.GetInstance;

        [MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms"), EditorBrowsable(EditorBrowsableState.Never)]
        internal sealed class MyForms
        {
            [ThreadStatic]
            private static Hashtable m_FormBeingCreated;
            public EFS_Professional.frmEFSProMain m_frmEFSProMain;
            public EFS_Professional.frmLauncher m_frmLauncher;
            public EFS_Professional.frmPIT_Magic_Main m_frmPIT_Magic_Main;
            public EFS_Professional.frmQualcommNVTools m_frmQualcommNVTools;
            public EFS_Professional.frmWaitDeviceDialog m_frmWaitDeviceDialog;
            public EFS_Professional.frmWaitDialog m_frmWaitDialog;

            [DebuggerHidden]
            private static T Create__Instance__<T>(T Instance) where T: Form, new()
            {
                T local;
                TargetInvocationException exception;
                if ((Instance != null) && !Instance.IsDisposed)
                {
                    return Instance;
                }
                if (m_FormBeingCreated != null)
                {
                    if (m_FormBeingCreated.ContainsKey(typeof(T)))
                    {
                        throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
                    }
                }
                else
                {
                    m_FormBeingCreated = new Hashtable();
                }
                m_FormBeingCreated.Add(typeof(T), null);
                try
                {
                    local = Activator.CreateInstance<T>();
                }
                catch (TargetInvocationException exception1) when ((exception.InnerException != null))
                {
                    ProjectData.SetProjectError(exception = exception1);
                    throw new InvalidOperationException(Utils.GetResourceString("WinForms_SeeInnerException", new string[] { exception.InnerException.Message }), exception.InnerException);
                }
                finally
                {
                    m_FormBeingCreated.Remove(typeof(T));
                }
                return local;
            }

            [DebuggerHidden]
            private void Dispose__Instance__<T>(ref T instance) where T: Form
            {
                instance.Dispose();
                instance = default(T);
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public override bool Equals(object o) => 
                base.Equals(RuntimeHelpers.GetObjectValue(o));

            [EditorBrowsable(EditorBrowsableState.Never)]
            public override int GetHashCode() => 
                base.GetHashCode();

            [EditorBrowsable(EditorBrowsableState.Never)]
            internal Type GetType() => 
                typeof(MyProject.MyForms);

            [EditorBrowsable(EditorBrowsableState.Never)]
            public override string ToString() => 
                base.ToString();

            public EFS_Professional.frmEFSProMain frmEFSProMain
            {
                get
                {
                    this.m_frmEFSProMain = Create__Instance__<EFS_Professional.frmEFSProMain>(this.m_frmEFSProMain);
                    return this.m_frmEFSProMain;
                }
                set
                {
                    if (value != this.m_frmEFSProMain)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        this.Dispose__Instance__<EFS_Professional.frmEFSProMain>(ref this.m_frmEFSProMain);
                    }
                }
            }

            public EFS_Professional.frmLauncher frmLauncher
            {
                get
                {
                    this.m_frmLauncher = Create__Instance__<EFS_Professional.frmLauncher>(this.m_frmLauncher);
                    return this.m_frmLauncher;
                }
                set
                {
                    if (value != this.m_frmLauncher)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        this.Dispose__Instance__<EFS_Professional.frmLauncher>(ref this.m_frmLauncher);
                    }
                }
            }

            public EFS_Professional.frmPIT_Magic_Main frmPIT_Magic_Main
            {
                get
                {
                    this.m_frmPIT_Magic_Main = Create__Instance__<EFS_Professional.frmPIT_Magic_Main>(this.m_frmPIT_Magic_Main);
                    return this.m_frmPIT_Magic_Main;
                }
                set
                {
                    if (value != this.m_frmPIT_Magic_Main)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        this.Dispose__Instance__<EFS_Professional.frmPIT_Magic_Main>(ref this.m_frmPIT_Magic_Main);
                    }
                }
            }

            public EFS_Professional.frmQualcommNVTools frmQualcommNVTools
            {
                get
                {
                    this.m_frmQualcommNVTools = Create__Instance__<EFS_Professional.frmQualcommNVTools>(this.m_frmQualcommNVTools);
                    return this.m_frmQualcommNVTools;
                }
                set
                {
                    if (value != this.m_frmQualcommNVTools)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        this.Dispose__Instance__<EFS_Professional.frmQualcommNVTools>(ref this.m_frmQualcommNVTools);
                    }
                }
            }

            public EFS_Professional.frmWaitDeviceDialog frmWaitDeviceDialog
            {
                get
                {
                    this.m_frmWaitDeviceDialog = Create__Instance__<EFS_Professional.frmWaitDeviceDialog>(this.m_frmWaitDeviceDialog);
                    return this.m_frmWaitDeviceDialog;
                }
                set
                {
                    if (value != this.m_frmWaitDeviceDialog)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        this.Dispose__Instance__<EFS_Professional.frmWaitDeviceDialog>(ref this.m_frmWaitDeviceDialog);
                    }
                }
            }

            public EFS_Professional.frmWaitDialog frmWaitDialog
            {
                get
                {
                    this.m_frmWaitDialog = Create__Instance__<EFS_Professional.frmWaitDialog>(this.m_frmWaitDialog);
                    return this.m_frmWaitDialog;
                }
                set
                {
                    if (value != this.m_frmWaitDialog)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        this.Dispose__Instance__<EFS_Professional.frmWaitDialog>(ref this.m_frmWaitDialog);
                    }
                }
            }
        }

        [MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", ""), EditorBrowsable(EditorBrowsableState.Never)]
        internal sealed class MyWebServices
        {
            [DebuggerHidden]
            private static T Create__Instance__<T>(T instance) where T: new()
            {
                if (instance == null)
                {
                    return Activator.CreateInstance<T>();
                }
                return instance;
            }

            [DebuggerHidden]
            private void Dispose__Instance__<T>(ref T instance)
            {
                instance = default(T);
            }

            [EditorBrowsable(EditorBrowsableState.Never), DebuggerHidden]
            public override bool Equals(object o) => 
                base.Equals(RuntimeHelpers.GetObjectValue(o));

            [EditorBrowsable(EditorBrowsableState.Never), DebuggerHidden]
            public override int GetHashCode() => 
                base.GetHashCode();

            [DebuggerHidden, EditorBrowsable(EditorBrowsableState.Never)]
            internal Type GetType() => 
                typeof(MyProject.MyWebServices);

            [DebuggerHidden, EditorBrowsable(EditorBrowsableState.Never)]
            public override string ToString() => 
                base.ToString();
        }

        [ComVisible(false), EditorBrowsable(EditorBrowsableState.Never)]
        internal sealed class ThreadSafeObjectProvider<T> where T: new()
        {
            [ThreadStatic, CompilerGenerated]
            private static T m_ThreadStaticValue;

            internal T GetInstance
            {
                [DebuggerHidden]
                get
                {
                    if (MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue == null)
                    {
                        MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue = Activator.CreateInstance<T>();
                    }
                    return MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue;
                }
            }
        }
    }
}

