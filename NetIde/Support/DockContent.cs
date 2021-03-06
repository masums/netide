﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.ComponentModel;
using System.Windows.Automation;
using System.Windows.Automation.Provider;
using System.Windows.Forms;
using NetIde.Util.Forms;
using NetIde.Win32;
using UIAutomationWrapper;
using ControlType = System.Windows.Automation.ControlType;

namespace NetIde.Support
{
    internal class DockContent : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        private readonly FormHelper _fixer;
        private bool _disposed;

        public DockContent()
        {
            _fixer = new FormHelper(this);
            _fixer.EnableBoundsTracking = false;

            ElementProvider.Install(new DockContentElementProvider(this));
        }

        public event BrowseButtonEventHandler BrowseButtonClick;

        protected virtual void OnBrowseButtonClick(BrowseButtonEventArgs e)
        {
            var ev = BrowseButtonClick;

            if (ev != null)
                ev(this, e);
        }

        protected string UserSettingsKey
        {
            get { return _fixer.KeyAddition; }
            set { _fixer.KeyAddition = value; }
        }

        protected override void SetVisibleCore(bool value)
        {
            _fixer.InitializeForm();

            base.SetVisibleCore(value);
        }

        protected override void Dispose(bool disposing)
        {
            if (!_disposed && disposing)
            {
                if (!_fixer.InDesignMode)
                    _fixer.StoreUserSettings();

                _disposed = true;
            }

            base.Dispose(disposing);
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);

            _fixer.OnSizeChanged(e);
        }

        protected override void OnLocationChanged(EventArgs e)
        {
            base.OnLocationChanged(e);

            _fixer.OnLocationChanged(e);
        }

        public void CenterOverParent(double relativeSize)
        {
            _fixer.CenterOverParent(relativeSize);
        }

        public void TrackProperty(Control control, string property)
        {
            _fixer.TrackProperty(control, property);
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        public new AutoScaleMode AutoScaleMode
        {
            get { return base.AutoScaleMode; }
            set
            {
                // This value is set by the designer. To not have to manually change the
                // defaults set by the designer, it's silently ignored here at runtime.

                if (_fixer.InDesignMode)
                    base.AutoScaleMode = value;
            }
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case NativeMethods.WM_PARENTNOTIFY:
                    switch (NativeMethods.Util.LOWORD(m.WParam))
                    {
                        case NativeMethods.WM_XBUTTONDOWN:
                            switch (NativeMethods.Util.HIWORD(m.WParam))
                            {
                                case NativeMethods.XBUTTON1:
                                    OnBrowseButtonClick(new BrowseButtonEventArgs(BrowseButton.Back));
                                    break;

                                case NativeMethods.XBUTTON2:
                                    OnBrowseButtonClick(new BrowseButtonEventArgs(BrowseButton.Forward));
                                    break;
                            }
                            break;
                    }
                    break;

                case NativeMethods.WM_APPCOMMAND:
                    int cmd = NativeMethods.Util.HIWORD(m.LParam) & ~0xf000;

                    switch (cmd)
                    {
                        case NativeMethods.APPCOMMAND_BROWSER_BACKWARD:
                            OnBrowseButtonClick(new BrowseButtonEventArgs(BrowseButton.Back));
                            m.Result = (IntPtr)1;
                            return;

                        case NativeMethods.APPCOMMAND_BROWSER_FORWARD:
                            OnBrowseButtonClick(new BrowseButtonEventArgs(BrowseButton.Forward));
                            m.Result = (IntPtr)1;
                            return;
                    }
                    break;
            }

            base.WndProc(ref m);
        }

        [ComVisible(true)]
        private class DockContentElementProvider : ElementProvider, IWindowProvider
        {
            public new DockContent Control
            {
                get { return (DockContent)base.Control; }
            }

            public DockContentElementProvider(DockContent dockContent)
                : base(dockContent)
            {
            }

            public override ProviderOptions ProviderOptions
            {
                get { return ProviderOptions.ServerSideProvider | ProviderOptions.UseComThreading; }
            }

            public override ControlType ControlType
            {
                get { return ControlType.Window; }
            }

            void IWindowProvider.Close()
            {
                Control.Close();
            }

            WindowInteractionState IWindowProvider.InteractionState
            {
                get { return WindowInteractionState.Running; }
            }

            bool IWindowProvider.IsModal
            {
                get { return false; }
            }

            bool IWindowProvider.IsTopmost
            {
                get { return ((DockPanel)Control.DockPanel).ActiveDocument == Control; }
            }

            bool IWindowProvider.Maximizable
            {
                get { return false; }
            }

            bool IWindowProvider.Minimizable
            {
                get { return false; }
            }

            void IWindowProvider.SetVisualState(WindowVisualState state)
            {
                // Not supported.
            }

            WindowVisualState IWindowProvider.VisualState
            {
                get { return WindowVisualState.Normal; }
            }

            bool IWindowProvider.WaitForInputIdle(int milliseconds)
            {
                // Not supported.

                return true;
            }
        }
    }
}
