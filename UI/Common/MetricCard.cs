using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace DCSSMeetingScheduler.UI.Common {
    public class MetricCard : Panel {
        private string _title = "Metric";
        private string _value = "0";
        private string _subtitle = "Total records";
        private string _iconGlyph = "📊";
        private Color _accentColor = ThemeColors.PrimaryRed;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Title {
            get => _title;
            set { _title = value; Invalidate(); }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Value {
            get => _value;
            set { _value = value; Invalidate(); }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Subtitle {
            get => _subtitle;
            set { _subtitle = value; Invalidate(); }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string IconGlyph {
            get => _iconGlyph;
            set { _iconGlyph = value; Invalidate(); }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color AccentColor {
            get => _accentColor;
            set { _accentColor = value; Invalidate(); }
        }

        public MetricCard() {
            DoubleBuffered = true;
            BackColor = ThemeColors.CardBackground;
            Size = new Size(220, 110);
            Padding = new Padding(16);
            Font = new Font("Segoe UI", 9F);
        }

        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            var rect = new Rectangle(0, 0, Width - 1, Height - 1);

            // Fill card background
            using (var brush = new SolidBrush(ThemeColors.CardBackground)) {
                g.FillRectangle(brush, rect);
            }

            // Draw border
            using (var pen = new Pen(ThemeColors.BorderGray, 1)) {
                g.DrawRectangle(pen, rect);
            }

            // Top accent strip in Red
            using (var brush = new SolidBrush(_accentColor)) {
                g.FillRectangle(brush, 0, 0, Width, 4);
            }

            // Draw Icon circle/background on top right
            int iconBoxSize = 36;
            var iconRect = new Rectangle(Width - iconBoxSize - 16, 16, iconBoxSize, iconBoxSize);
            using (var brush = new SolidBrush(ThemeColors.LightRed)) {
                g.FillEllipse(brush, iconRect);
            }
            using (var pen = new Pen(ThemeColors.LightRedBorder, 1)) {
                g.DrawEllipse(pen, iconRect);
            }
            using (var font = new Font("Segoe UI Emoji", 13F, FontStyle.Regular))
            using (var brush = new SolidBrush(_accentColor)) {
                var sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
                g.DrawString(_iconGlyph, font, brush, iconRect, sf);
            }

            // Draw Title (small uppercase gray)
            using (var font = new Font("Segoe UI", 8.5F, FontStyle.Bold))
            using (var brush = new SolidBrush(ThemeColors.TextMuted)) {
                g.DrawString(_title.ToUpperInvariant(), font, brush, 16, 16);
            }

            // Draw Value (bold large text)
            using (var font = new Font("Segoe UI", 20F, FontStyle.Bold))
            using (var brush = new SolidBrush(ThemeColors.TextDark)) {
                g.DrawString(_value, font, brush, 16, 36);
            }

            // Draw Subtitle (small muted body text)
            using (var font = new Font("Segoe UI", 8F, FontStyle.Regular))
            using (var brush = new SolidBrush(ThemeColors.TextMuted)) {
                g.DrawString(_subtitle, font, brush, 16, Height - 24);
            }
        }
    }
}
