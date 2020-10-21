﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWPPopupToolkit.Controls.PopupControl;
using UWPPopupToolkit.Controls.SlideupPopup;
using Windows.UI.Xaml;

namespace UWPPopupToolkit.Controls.PopupPresenterHost
{
    public partial class PopupPresenterHost
    {
        public static async Task<Guid> ShowSlideupPopupAsync(Type content, double ContentHeight = double.NaN, string Host_Id = null, bool OpenNewIfExists = true, params object[] args)
        {
            PopupPresenterHost Host = null;
            if (Host_Id == null)
                Host = _hosts.Any() ? _hosts.FirstOrDefault() : throw new Exception("Mo Hosts found or the host disposed.");
            else Host = _hosts.Any() ? _hosts.First(x => x.Id == Host_Id) : throw new Exception("Mo Hosts found or the host disposed.");
            if (Host.Children.Any(x => x is SlideupPopup.SlideupPopup slideup && slideup.PopupContentType == content))
                if (!OpenNewIfExists)
                    throw new Exception("An existing popup of this type is currently open.");
            var p = new SlideupPopup.SlideupPopup(content, args) { PopupHeight = ContentHeight };
            Host.Children.Add(p);
            await p.ShowPopupAsync();
            return p.Identifier;
        }

        public static Guid ShowSlideupPopup(Type content, double ContentHeight = double.NaN, string Host_Id = null, bool OpenNewIfExists = true, params object[] args)
        {
            PopupPresenterHost Host = null;
            if (Host_Id == null)
                Host = _hosts.Any() ? _hosts.FirstOrDefault() : throw new Exception("Mo Hosts found or the host disposed.");
            else Host = _hosts.Any() ? _hosts.First(x => x.Id == Host_Id) : throw new Exception("Mo Hosts found or the host disposed.");
            if (Host.Children.Any(x => x is SlideupPopup.SlideupPopup slideup && slideup.PopupContentType == content))
                if (!OpenNewIfExists)
                    throw new Exception("An existing popup of this type is currently open.");
            var p = new SlideupPopup.SlideupPopup(content, args) { PopupHeight = ContentHeight };
            Host.Children.Add(p);
            p.ShowPopup();
            return p.Identifier;
        }

        public static async void HideSlideupPopup(Guid Identifier, string Host_Id = null)
        {
            PopupPresenterHost Host = null;
            if (Host_Id == null)
                Host = _hosts.Any() ? _hosts.FirstOrDefault(x => x.Children.Any(y => y.GetType() == typeof(SlideupPopup.SlideupPopup) && (y as SlideupPopup.SlideupPopup).Identifier == Identifier)) : throw new Exception("Mo Hosts found or the host disposed.");
            else Host = !_hosts.Any() ? throw new Exception("Mo Hosts found or the host disposed.") :
            _hosts.Any(x => x.Id == Host_Id) ? _hosts.First(x => x.Id == Host_Id) : throw new Exception("Mo Hosts found or the host disposed.");
            if (Host.Children.Any(x => x is SlideupPopup.SlideupPopup uc && uc.Identifier == Identifier))
            {
                var uc = (SlideupPopup.SlideupPopup)Host.Children.FirstOrDefault(x => x is SlideupPopup.SlideupPopup uc && uc.Identifier == Identifier);
                uc.Dispose();
                await Task.Delay((int)uc.AnimationDuration.TimeSpan.TotalMilliseconds);
                Host.Children.Remove(uc);
            }
        }

        public static async Task HideSlideupPopupAsync(Guid Identifier, string Host_Id = null)
        {
            PopupPresenterHost Host = null;
            if (Host_Id == null)
                Host = _hosts.Any() ? _hosts.FirstOrDefault(x => x.Children.Any(y => y.GetType() == typeof(SlideupPopup.SlideupPopup) && (y as SlideupPopup.SlideupPopup).Identifier == Identifier)) : throw new Exception("Mo Hosts found or the host disposed.");
            else Host = !_hosts.Any() ? throw new Exception("Mo Hosts found or the host disposed.") :
            _hosts.Any(x => x.Id == Host_Id) ? _hosts.First(x => x.Id == Host_Id) : throw new Exception("Mo Hosts found or the host disposed.");
            if (Host.Children.Any(x => x is SlideupPopup.SlideupPopup uc && uc.Identifier == Identifier))
            {
                var uc = (SlideupPopup.SlideupPopup)Host.Children.FirstOrDefault(x => x is SlideupPopup.SlideupPopup uc && uc.Identifier == Identifier);
                uc.Dispose();
                await Task.Delay((int)uc.AnimationDuration.TimeSpan.TotalMilliseconds);
                Host.Children.Remove(uc);
            }
        }

        public static Guid ShowPopupControl(Type content, string Host_Id = null, bool OpenNewIfExists = true, PopupControlAnimationKind AnimationKind = PopupControlAnimationKind.FadeIn, params object[] args)
        {
            PopupPresenterHost Host = null;
            if (Host_Id == null)
                Host = _hosts.Any() ? _hosts.FirstOrDefault() : throw new Exception("Mo Hosts found or the host disposed.");
            else Host = _hosts.Any() ? _hosts.First(x => x.Id == Host_Id) : throw new Exception("Mo Hosts found or the host disposed.");
            if (Host.Children.Any(x => x is PopupControl.PopupControl pop && pop.PopupContentType == content))
                if (!OpenNewIfExists)
                    throw new Exception("An existing popup of this type is currently open.");
            var p = new PopupControl.PopupControl(content, args);
            Host.Children.Add(p);
            p.ShowPopup();
            return p.Identifier;
        }

        public static async Task<Guid> ShowPopupControlAsync(Type content, string Host_Id = null, bool OpenNewIfExists = true, PopupControlAnimationKind AnimationKind = PopupControlAnimationKind.FadeIn, params object[] args)
        {
            PopupPresenterHost Host = null;
            if (Host_Id == null)
                Host = _hosts.Any() ? _hosts.FirstOrDefault() : throw new Exception("Mo Hosts found or the host disposed.");
            else Host = _hosts.Any() ? _hosts.First(x => x.Id == Host_Id) : throw new Exception("Mo Hosts found or the host disposed.");
            if (Host.Children.Any(x => x is PopupControl.PopupControl pop && pop.PopupContentType == content))
                if (!OpenNewIfExists)
                    throw new Exception("An existing popup of this type is currently open.");
            var p = new PopupControl.PopupControl(content, args);
            Host.Children.Add(p);
            await p.ShowPopupAsync();
            return p.Identifier;
        }
        
        public static async void HidePopupControl(Guid Identifier, string Host_Id = null)
        {
            PopupPresenterHost Host = null;
            if (Host_Id == null)
                Host = _hosts.Any() ? _hosts.FirstOrDefault(x => x.Children.Any(y => y.GetType() == typeof(PopupControl.PopupControl) && (y as PopupControl.PopupControl).Identifier == Identifier)) : throw new Exception("Mo Hosts found or the host disposed.");
            else Host = !_hosts.Any() ? throw new Exception("Mo Hosts found or the host disposed.") :
            _hosts.Any(x => x.Id == Host_Id) ? _hosts.First(x => x.Id == Host_Id) : throw new Exception("Mo Hosts found or the host disposed.");
            if (Host.Children.Any(x => x is PopupControl.PopupControl uc && uc.Identifier == Identifier))
            {
                var uc = (PopupControl.PopupControl)Host.Children.FirstOrDefault(x => x is PopupControl.PopupControl uc && uc.Identifier == Identifier);
                uc.HidePopup();
                await Task.Delay((int)uc.HideAnimationDuration.TimeSpan.TotalMilliseconds);
                uc.Dispose();
                Host.Children.Remove(uc);
            }
        }

        public static void HidePopupControl(FrameworkElement popupContent, string Host_Id = null)
        {
            var id = PopupControl.PopupControl.GetIdentifier(popupContent);
            HidePopupControl(id, Host_Id);
        }

        public static async Task HidePopupControlAsync(Guid Identifier, string Host_Id = null)
        {
            PopupPresenterHost Host = null;
            if (Host_Id == null)
                Host = _hosts.Any() ? _hosts.FirstOrDefault(x => x.Children.Any(y => y.GetType() == typeof(PopupControl.PopupControl) && (y as PopupControl.PopupControl).Identifier == Identifier)) : throw new Exception("Mo Hosts found or the host disposed.");
            else Host = !_hosts.Any() ? throw new Exception("Mo Hosts found or the host disposed.") :
            _hosts.Any(x => x.Id == Host_Id) ? _hosts.First(x => x.Id == Host_Id) : throw new Exception("Mo Hosts found or the host disposed.");
            if (Host.Children.Any(x => x is PopupControl.PopupControl uc && uc.Identifier == Identifier))
            {
                var uc = (PopupControl.PopupControl)Host.Children.FirstOrDefault(x => x is PopupControl.PopupControl uc && uc.Identifier == Identifier);
                await uc.HidePopupAsync();
                Host.Children.Remove(uc);
            }
        }

        public static async Task HidePopupControlAsync(FrameworkElement popupContent, string Host_Id = null)
        {
            var id = PopupControl.PopupControl.GetIdentifier(popupContent);
            await HidePopupControlAsync(id, Host_Id);
        }

    }
}
