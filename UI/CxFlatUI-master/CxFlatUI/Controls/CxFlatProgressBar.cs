﻿using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;


namespace CxFlatUI
{
    public class CxFlatProgressBar : Control
    {
        public enum Style
        {
            ToolTip = 0,
            ValueInSide = 1,
            ValueOutSide = 2
        }

        private Style _style = Style.ToolTip;
        public Style ProgressBarStyle
        {
            get { return _style; }
            set
            {
                _style = value;
                Invalidate();
            }
        }

        private bool _isError = false;
        public bool IsError
        {
            get { return _isError; }
            set
            {
                _isError = value;
                Invalidate();
            }
        }

        private int _valueNumber = 0;
        public int ValueNumber
        {
            get { return _valueNumber; }
            set
            {
                _valueNumber = value > 100 ? 100 : (value < 0 ? 0 : value);
                Invalidate();
            }
        }

        #region 事件
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            switch (_style)
            {
                case Style.ToolTip:
                    Height = 32;
                    break;
                case Style.ValueInSide:
                    Height = 14;
                    break;
                case Style.ValueOutSide:
                    Height = 14;
                    break;
            }
        }

        #endregion

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = SmoothingMode.HighQuality;
            graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
            graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            graphics.Clear(Parent.BackColor);

            var tempColor = _isError ? ThemeColors.Danger : ThemeColors.PrimaryColor;

            switch (_style)
            {
                case Style.ToolTip:
                    var x = _valueNumber * (Width - 32) / 100 + 16f;
                    var y = 25;
                    graphics.FillPolygon(new SolidBrush(_valueNumber == 100 && !_isError ? ThemeColors.Success : tempColor), new PointF[]
                    {
                         new PointF(x,y),new PointF(x+5,y-5),new PointF(x+16,y-5),new PointF(x+16,y-25),new PointF(x-16,y-25),new PointF(x-16,y-5),new PointF(x-5,y-5)
                    });
                    graphics.DrawString(_valueNumber != 100 ? _valueNumber.ToString() + "%" : "ok!", Font, new SolidBrush(ThemeColors.FourLevelBorder), new RectangleF(x - 16, y - 25, 32, 20), StringAlign.Center);

                    graphics.FillRectangle(new SolidBrush(ThemeColors.OneLevelBorder), new RectangleF(16, 25, Width - 32, Height - 25));
                    graphics.FillRectangle(new SolidBrush(_valueNumber == 100&&!_isError ? ThemeColors.Success : tempColor), new RectangleF(16, 25, x - 16, Height - 25));
                    break;

                case Style.ValueInSide:
                    var path1 = new GraphicsPath();
                    path1.AddArc(new RectangleF(0, 0, Height, Height), 90, 180);
                    path1.AddArc(new RectangleF(Width - Height, 0, Height, Height), -90, 180);
                    path1.CloseAllFigures();
                    graphics.FillPath(new SolidBrush(ThemeColors.OneLevelBorder), path1);

                    if (_valueNumber == 0)
                    {
                        graphics.DrawString("0%", new Font("微软雅黑", 9f), new SolidBrush(ThemeColors.FourLevelBorder), new RectangleF(5, 0, 50, Height), StringAlign.Left);
                    }
                    else
                    {
                        var path2 = new GraphicsPath();
                        path2.AddArc(new RectangleF(0, 0, Height, Height), 90, 180);
                        path2.AddArc(new RectangleF(_valueNumber * (Width - Height) / 100, 0, Height, Height), -90, 180);
                        path2.CloseAllFigures();
                        graphics.FillPath(new SolidBrush(_valueNumber == 100&&!_isError ? ThemeColors.Success : tempColor), path2);

                        graphics.DrawString(_valueNumber.ToString() + "%", new Font("微软雅黑", 9f), new SolidBrush(ThemeColors.FourLevelBorder), new RectangleF(_valueNumber * (Width -Height) / 100 - 33, 0, 45, Height), StringAlign.Right);
                    }
                    break;
                case Style.ValueOutSide:
                    var path3 = new GraphicsPath();
                    path3.AddArc(new RectangleF(0, 4, Height-8, Height-8), 90, 180);
                    path3.AddArc(new RectangleF(Width - 50, 4, Height-8, Height-8), -90, 180);
                    path3.CloseAllFigures();
                    graphics.FillPath(new SolidBrush(ThemeColors.OneLevelBorder), path3);

                    if(_valueNumber!=0)
                    {
                        var path4 = new GraphicsPath();
                        path4.AddArc(new RectangleF(0, 4, Height-8, Height-8), 90, 180);
                        path4.AddArc(new RectangleF(_valueNumber * (Width - 50) / 100, 4, Height-8, Height-8), -90, 180);
                        path4.CloseAllFigures();
                        graphics.FillPath(new SolidBrush(_valueNumber == 100&&!_isError ? ThemeColors.Success : tempColor), path4);
                    }

                    if(_isError)
                    {
                        graphics.FillEllipse(new SolidBrush(ThemeColors.Danger), new RectangleF(Width - 40, 0, Height, Height));
                        var a = Width - 40 + 4;
                        var b = Height - 4;
                        graphics.DrawLine(new Pen(ThemeColors.FourLevelBorder), a,b-6,a+6,b);
                        graphics.DrawLine(new Pen(ThemeColors.FourLevelBorder), a+6, b-6, a, b);
                    }
                    else
                    {
                        if(_valueNumber==100)
                        {
                            graphics.FillEllipse(new SolidBrush(ThemeColors.Success), new RectangleF(Width - 40, 0, Height, Height));
                            var a = Width - 40 + 4;
                            var b = Height - 4;
                            graphics.DrawLine(new Pen(ThemeColors.FourLevelBorder), a, b - 3, a + 3, b);
                            graphics.DrawLine(new Pen(ThemeColors.FourLevelBorder), a + 3, b, a+6, b-6);
                        }
                        else
                        {
                            graphics.DrawString(_valueNumber.ToString() + "%", new Font("微软雅黑", 10f), new SolidBrush(ThemeColors.MainText), new RectangleF(Width - 40, 0, 50, Height), StringAlign.Left);
                        }
                    }
                    break;
            }
        }

        public CxFlatProgressBar()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer | ControlStyles.SupportsTransparentBackColor, true);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 10);
        }
    }
}