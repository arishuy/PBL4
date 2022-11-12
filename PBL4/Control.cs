using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PBL4
{
    static class Control
    {
        static bool isMax = false, isFull = false;
        static Point old_loc, default_loc;
        static Size old_size, default_size;

        public static bool CheckForIllegalCrossThreadCalls { get; internal set; }

        public static void SetIntial(Form form) //this method should fire when app starts
        {
            old_loc = form.Location;
            old_size = form.Size;
            default_loc = form.Location;
            default_size = form.Size;
        }

        public static void DoMaximize(Form form, Guna2Button Maxbtn)
        {
            if (isMax == false) // app not maximized ; then MAXIMIZED IT!
            {
                old_loc = new Point(form.Location.X, form.Location.Y);
                old_size = new Size(form.Size.Width, form.Size.Height);
                Maximize(form);
                isMax = true;
                isFull = false;
                Maxbtn.Text = "2";
            }

            else // app is currently maximed; then make it normal!
            {
                if (old_size.Width >= SystemInformation.WorkingArea.Width || old_size.Height >= SystemInformation.WorkingArea.Height)
                {
                    form.Location = default_loc;
                    form.Size = default_size;
                }
                else
                {
                    form.Location = old_loc;
                    form.Size = old_size;
                }
                isMax = false;
                isFull = false;
                Maxbtn.Text = "1";
            }
        }

        public static void DoFullscreen(Form form)
        {
            if (isFull == false) // app not fullscreeb ; then fullscreen IT!
            {
                old_loc = new Point(form.Location.X, form.Location.Y);
                old_size = new Size(form.Size.Width, form.Size.Height);
                Fullscreen(form);
                isMax = false;
                isFull = true;
            }

            else // app is currently fullscreen; then make it normal!
            {
                if (old_size.Width >= SystemInformation.WorkingArea.Width || old_size.Height >= SystemInformation.WorkingArea.Height)
                {
                    form.Location = default_loc;
                    form.Size = default_size;
                }
                else
                {
                    form.Location = old_loc;
                    form.Size = old_size;
                }
                Fullscreen(form);
                isMax = false;
                isFull = false;
            }
        }

        static void Fullscreen(Form form)
        {
            if (form.WindowState == FormWindowState.Maximized)
                form.WindowState = FormWindowState.Normal;
            else if (form.WindowState == FormWindowState.Normal)
                form.WindowState = FormWindowState.Maximized;
        }

        static void Maximize(Form form)
        {
            int x = SystemInformation.WorkingArea.Width;
            int y = SystemInformation.WorkingArea.Height;
            form.WindowState = FormWindowState.Normal;
            form.Location = new Point(0, 0);
            form.Size = new Size(x, y);
        }

        public static void Minimize(Form form)
        {
            if (form.WindowState == FormWindowState.Minimized)
                form.WindowState = FormWindowState.Normal;
            else if (form.WindowState == FormWindowState.Normal)
                form.WindowState = FormWindowState.Minimized;
        }

        public static void Exit()
        {
            Application.Exit();
        }
    }
}