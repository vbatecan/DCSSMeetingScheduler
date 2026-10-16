using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using DCSSMeetingScheduler.Models;

namespace DCSSMeetingScheduler.UI.Common {
    public static class UIHelper {
        public static void StylePrimaryButton(Button btn, string? text = null) {
            if (text != null) btn.Text = text;
            btn.BackColor = ThemeColors.PrimaryRed;
            btn.ForeColor = ThemeColors.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btn.Cursor = Cursors.Hand;
            btn.UseVisualStyleBackColor = false;

            btn.MouseEnter -= OnPrimaryButtonMouseEnter;
            btn.MouseEnter += OnPrimaryButtonMouseEnter;
            btn.MouseLeave -= OnPrimaryButtonMouseLeave;
            btn.MouseLeave += OnPrimaryButtonMouseLeave;
        }

        private static void OnPrimaryButtonMouseEnter(object? sender, EventArgs e) {
            if (sender is Button b) b.BackColor = ThemeColors.PrimaryRedLight;
        }

        private static void OnPrimaryButtonMouseLeave(object? sender, EventArgs e) {
            if (sender is Button b) b.BackColor = ThemeColors.PrimaryRed;
        }

        public static void StyleSecondaryButton(Button btn, string? text = null) {
            if (text != null) btn.Text = text;
            btn.BackColor = ThemeColors.White;
            btn.ForeColor = ThemeColors.PrimaryRed;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderColor = ThemeColors.PrimaryRed;
            btn.FlatAppearance.BorderSize = 1;
            btn.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btn.Cursor = Cursors.Hand;
            btn.UseVisualStyleBackColor = false;

            btn.MouseEnter -= OnSecondaryButtonMouseEnter;
            btn.MouseEnter += OnSecondaryButtonMouseEnter;
            btn.MouseLeave -= OnSecondaryButtonMouseLeave;
            btn.MouseLeave += OnSecondaryButtonMouseLeave;
        }

        private static void OnSecondaryButtonMouseEnter(object? sender, EventArgs e) {
            if (sender is Button b) b.BackColor = ThemeColors.LightRed;
        }

        private static void OnSecondaryButtonMouseLeave(object? sender, EventArgs e) {
            if (sender is Button b) b.BackColor = ThemeColors.White;
        }

        public static void StyleDangerButton(Button btn, string? text = null) {
            if (text != null) btn.Text = text;
            btn.BackColor = Color.FromArgb(220, 38, 38);
            btn.ForeColor = ThemeColors.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn.Cursor = Cursors.Hand;
            btn.UseVisualStyleBackColor = false;
        }

        public static void StyleTextBox(TextBox tb) {
            tb.BorderStyle = BorderStyle.FixedSingle;
            tb.Font = new Font("Segoe UI", 9.5F);
            tb.ForeColor = ThemeColors.TextDark;
            tb.BackColor = ThemeColors.White;
        }

        public static void StyleComboBox(ComboBox cb) {
            cb.FlatStyle = FlatStyle.Flat;
            cb.DropDownStyle = ComboBoxStyle.DropDownList;
            cb.Font = new Font("Segoe UI", 9.5F);
            cb.ForeColor = ThemeColors.TextDark;
            cb.BackColor = ThemeColors.White;
        }

        public static void StyleDataGridView(DataGridView dgv) {
            dgv.BackgroundColor = ThemeColors.CanvasBackground;
            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.GridColor = ThemeColors.BorderGray;
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.RowHeadersVisible = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.AutoGenerateColumns = false;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeRows = false;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv.ColumnHeadersHeight = 42;
            dgv.RowTemplate.Height = 40;

            // Column Header Style (UE Deep Red)
            dgv.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle {
                BackColor = ThemeColors.PrimaryRedDark,
                ForeColor = ThemeColors.White,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                Alignment = DataGridViewContentAlignment.MiddleLeft,
                Padding = new Padding(10, 0, 10, 0)
            };

            // Regular Cell Style
            dgv.DefaultCellStyle = new DataGridViewCellStyle {
                BackColor = ThemeColors.White,
                ForeColor = ThemeColors.TextDark,
                Font = new Font("Segoe UI", 9F),
                SelectionBackColor = ThemeColors.LightRed,
                SelectionForeColor = ThemeColors.PrimaryRedDark,
                Padding = new Padding(8, 0, 8, 0),
                Alignment = DataGridViewContentAlignment.MiddleLeft
            };

            // Alternating Row Style
            dgv.AlternatingRowsDefaultCellStyle = new DataGridViewCellStyle {
                BackColor = Color.FromArgb(250, 250, 252),
                ForeColor = ThemeColors.TextDark,
                SelectionBackColor = ThemeColors.LightRed,
                SelectionForeColor = ThemeColors.PrimaryRedDark,
                Padding = new Padding(8, 0, 8, 0)
            };
        }

        public static void RenderStatusCell(DataGridViewCellPaintingEventArgs e, string text, MeetingStatus status) {
            if (e.Graphics == null) return;
            e.Handled = true;
            e.PaintBackground(e.CellBounds, true);

            var (bgColor, textColor) = status switch {
                MeetingStatus.Approved => (ThemeColors.StatusApprovedBg, ThemeColors.StatusApprovedText),
                MeetingStatus.Pending => (ThemeColors.StatusPendingBg, ThemeColors.StatusPendingText),
                MeetingStatus.Rescheduled => (ThemeColors.StatusRescheduledBg, ThemeColors.StatusRescheduledText),
                MeetingStatus.Declined => (ThemeColors.StatusDeclinedBg, ThemeColors.StatusDeclinedText),
                MeetingStatus.Cancelled => (ThemeColors.StatusCancelledBg, ThemeColors.StatusCancelledText),
                MeetingStatus.Completed => (ThemeColors.StatusCompletedBg, ThemeColors.StatusCompletedText),
                _ => (ThemeColors.LightGray, ThemeColors.TextRegular)
            };

            DrawBadge(e.Graphics, e.CellBounds, text, bgColor, textColor);
        }

        public static void RenderAccountStatusCell(DataGridViewCellPaintingEventArgs e, string text, AccountStatus status) {
            if (e.Graphics == null) return;
            e.Handled = true;
            e.PaintBackground(e.CellBounds, true);

            var (bgColor, textColor) = status == AccountStatus.Active
                ? (ThemeColors.StatusActiveBg, ThemeColors.StatusActiveText)
                : (ThemeColors.StatusInactiveBg, ThemeColors.StatusInactiveText);

            DrawBadge(e.Graphics, e.CellBounds, text, bgColor, textColor);
        }

        public static void DrawBadge(Graphics g, Rectangle bounds, string text, Color bg, Color fg) {
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            using var font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            var textSize = TextRenderer.MeasureText(text, font);
            int badgeWidth = Math.Max(textSize.Width + 16, 75);
            int badgeHeight = 22;

            int x = bounds.X + 8;
            int y = bounds.Y + (bounds.Height - badgeHeight) / 2;

            var pillRect = new Rectangle(x, y, badgeWidth, badgeHeight);

            using (var path = GetRoundedRectPath(pillRect, 10)) {
                using (var brush = new SolidBrush(bg)) {
                    g.FillPath(brush, path);
                }
            }

            var sf = new StringFormat {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            using (var textBrush = new SolidBrush(fg)) {
                g.DrawString(text, font, textBrush, pillRect, sf);
            }
        }

        public static GraphicsPath GetRoundedRectPath(Rectangle rect, int radius) {
            var path = new GraphicsPath();
            int diameter = radius * 2;
            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();
            return path;
        }

        public static Panel CreateCard(int padding = 16) {
            var pnl = new Panel {
                BackColor = ThemeColors.CardBackground,
                Padding = new Padding(padding)
            };
            pnl.Paint += (s, e) => {
                var g = e.Graphics;
                using var pen = new Pen(ThemeColors.BorderGray, 1);
                g.DrawRectangle(pen, 0, 0, pnl.Width - 1, pnl.Height - 1);
            };
            return pnl;
        }

        public static Panel CreatePageHeader(string title, string subtitle) {
            var pnl = new Panel {
                Dock = DockStyle.Top,
                Height = 65,
                BackColor = ThemeColors.CanvasBackground,
                Padding = new Padding(24, 12, 24, 8)
            };

            var lblTitle = new Label {
                Text = title,
                Font = new Font("Segoe UI", 14F, FontStyle.Bold),
                ForeColor = ThemeColors.TextDark,
                AutoSize = true,
                Location = new Point(24, 10)
            };

            var lblSub = new Label {
                Text = subtitle,
                Font = new Font("Segoe UI", 9F),
                ForeColor = ThemeColors.TextMuted,
                AutoSize = true,
                Location = new Point(24, 35)
            };

            pnl.Controls.Add(lblTitle);
            pnl.Controls.Add(lblSub);

            // subtle divider line
            pnl.Paint += (s, e) => {
                using var pen = new Pen(ThemeColors.BorderGray, 1);
                e.Graphics.DrawLine(pen, 24, pnl.Height - 1, pnl.Width - 24, pnl.Height - 1);
            };

            return pnl;
        }
    }
}
