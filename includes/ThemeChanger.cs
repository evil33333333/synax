using System;
using System.ComponentModel;
using System.IO;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Newtonsoft.Json;
using Synax.Includes.FujiPopup;

namespace Synax.Includes
{
	// Token: 0x02000027 RID: 39
	public class ThemeChanger
	{
		// Token: 0x0600015C RID: 348 RVA: 0x00007BD4 File Offset: 0x00007BD4
		public static ThemeObject DefaultTheme()
		{
			return new ThemeObject
			{
				Colors = new Colors
				{
					TitleColor = "#DEDEDE",
					LabelHeaderColor = "#F3F3F3",
					LabelLowerColor = "#818181",
					PrimaryDataColor = "#D4191C",
					HeaderDarkerColor = "#96999E",
					TextColor = "#FFFFFF",
					IconForegroundColor = "#D4191C",
					IconBackgroundColor = "#171717",
					ButtonForegroundColor = "#FFFFFF",
					ButtonBackgroundColor = "#D4191C",
					GridBackgroundColor = "#191C23",
					MainBackgroundColor = "#101010",
					SecondaryBackgroundColor = "#171717",
					HeaderColor = "#FFFFFF",
					SidebarColor = "#171717",
					LightSuccessColor = "#51d672",
					SuccessColor = "#2db84d",
					DarkSuccessColor = "#2db84d",
					LightDangerColor = "#B92F3A",
					DangerColor = "#db3340",
					DarkDangerColor = "#450c0f",
					LightInfoColor = "#00bcd4",
					InfoColor = "#00bcd4",
					DarkInfoColor = "#003c44",
					LightWarningColor = "#e9af20",
					WarningColor = "#e9af20",
					DarkWarningColor = "#4c3a0f"
				}
			};
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00007D1C File Offset: 0x00007D1C
		public static void UpdateColors(Color? titleColor = null, Color? labelHeaderColor = null, Color? labelLowerColor = null, Color? primaryDataColor = null, Color? headerDarkerColor = null, Color? textColor = null, Color? iconForgroundColor = null, Color? iconBackgroundColor = null, Color? buttonForgroundColor = null, Color? buttonBackgroundColor = null, Color? gridBackgroundColor = null, Color? mainBackgroundColor = null, Color? secondaryBackgroundColor = null, Color? headerColor = null, Color? sidebarColor = null, Color? lightSuccessColor = null, Color? successColor = null, Color? darkSuccessColor = null, Color? lightDangerColor = null, Color? dangerColor = null, Color? darkDangerColor = null, Color? lightInfoColor = null, Color? infoColor = null, Color? darkInfoColor = null, Color? lightWarningColor = null, Color? warningColor = null, Color? darkWarningColor = null)
		{
			try
			{
				if (titleColor != null)
				{
					ThemeChanger.SetColorResource("TitleColor", titleColor.Value);
				}
				if (labelHeaderColor != null)
				{
					ThemeChanger.SetColorResource("LabelHeaderColor", labelHeaderColor.Value);
				}
				if (labelLowerColor != null)
				{
					ThemeChanger.SetColorResource("LabelLowerColor", labelLowerColor.Value);
				}
				if (primaryDataColor != null)
				{
					ThemeChanger.SetColorResource("PrimaryDataColor", primaryDataColor.Value);
				}
				if (headerDarkerColor != null)
				{
					ThemeChanger.SetColorResource("HeaderDarkerColor", headerDarkerColor.Value);
				}
				if (textColor != null)
				{
					ThemeChanger.SetColorResource("TextColor", textColor.Value);
				}
				if (iconForgroundColor != null)
				{
					ThemeChanger.SetColorResource("IconForegroundColor", iconForgroundColor.Value);
				}
				if (iconBackgroundColor != null)
				{
					ThemeChanger.SetColorResource("IconBackgroundColor", iconBackgroundColor.Value);
				}
				if (buttonForgroundColor != null)
				{
					ThemeChanger.SetColorResource("ButtonForegroundColor", buttonForgroundColor.Value);
				}
				if (buttonBackgroundColor != null)
				{
					ThemeChanger.SetColorResource("ButtonBackgroundColor", buttonBackgroundColor.Value);
				}
				if (gridBackgroundColor != null)
				{
					ThemeChanger.SetColorResource("GridBackgroundColor", gridBackgroundColor.Value);
				}
				if (mainBackgroundColor != null)
				{
					ThemeChanger.SetColorResource("MainBackgroundColor", mainBackgroundColor.Value);
				}
				if (secondaryBackgroundColor != null)
				{
					ThemeChanger.SetColorResource("SecondaryBackgroundColor", secondaryBackgroundColor.Value);
				}
				if (headerColor != null)
				{
					ThemeChanger.SetColorResource("HeaderColor", headerColor.Value);
				}
				if (sidebarColor != null)
				{
					ThemeChanger.SetColorResource("SidebarColor", sidebarColor.Value);
				}
				if (lightSuccessColor != null)
				{
					ThemeChanger.SetColorResource("LightSuccessColor", lightSuccessColor.Value);
				}
				if (successColor != null)
				{
					ThemeChanger.SetColorResource("SuccessColor", successColor.Value);
				}
				if (darkSuccessColor != null)
				{
					ThemeChanger.SetColorResource("DarkSuccessColor", darkSuccessColor.Value);
				}
				if (lightDangerColor != null)
				{
					ThemeChanger.SetColorResource("LightDangerColor", lightDangerColor.Value);
				}
				if (dangerColor != null)
				{
					ThemeChanger.SetColorResource("DangerColor", dangerColor.Value);
				}
				if (darkDangerColor != null)
				{
					ThemeChanger.SetColorResource("DarkDangerColor", darkDangerColor.Value);
				}
				if (lightInfoColor != null)
				{
					ThemeChanger.SetColorResource("LightInfoColor", lightInfoColor.Value);
				}
				if (infoColor != null)
				{
					ThemeChanger.SetColorResource("InfoColor", infoColor.Value);
				}
				if (darkInfoColor != null)
				{
					ThemeChanger.SetColorResource("DarkInfoColor", darkInfoColor.Value);
				}
				if (lightWarningColor != null)
				{
					ThemeChanger.SetColorResource("LightWarningColor", lightWarningColor.Value);
				}
				if (warningColor != null)
				{
					ThemeChanger.SetColorResource("WarningColor", warningColor.Value);
				}
				if (darkWarningColor != null)
				{
					ThemeChanger.SetColorResource("DarkWarningColor", darkWarningColor.Value);
				}
			}
			catch
			{
				msgHost.dangerBox("Failed to update!", "An error has occurred while try to update the colors!", 5);
			}
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00008018 File Offset: 0x00008018
		public static void UpdateTheme(string json)
		{
			if (string.IsNullOrEmpty(json))
			{
				return;
			}
			Colors colors = JsonConvert.DeserializeObject<ThemeObject>(json).Colors;
			ThemeChanger.UpdateColors(new Color?((Color)ColorConverter.ConvertFromString(colors.TitleColor)), new Color?((Color)ColorConverter.ConvertFromString(colors.LabelHeaderColor)), new Color?((Color)ColorConverter.ConvertFromString(colors.LabelLowerColor)), new Color?((Color)ColorConverter.ConvertFromString(colors.PrimaryDataColor)), new Color?((Color)ColorConverter.ConvertFromString(colors.HeaderDarkerColor)), new Color?((Color)ColorConverter.ConvertFromString(colors.TextColor)), new Color?((Color)ColorConverter.ConvertFromString(colors.IconForegroundColor)), new Color?((Color)ColorConverter.ConvertFromString(colors.IconBackgroundColor)), new Color?((Color)ColorConverter.ConvertFromString(colors.ButtonForegroundColor)), new Color?((Color)ColorConverter.ConvertFromString(colors.ButtonBackgroundColor)), new Color?((Color)ColorConverter.ConvertFromString(colors.GridBackgroundColor)), new Color?((Color)ColorConverter.ConvertFromString(colors.MainBackgroundColor)), new Color?((Color)ColorConverter.ConvertFromString(colors.SecondaryBackgroundColor)), new Color?((Color)ColorConverter.ConvertFromString(colors.HeaderColor)), new Color?((Color)ColorConverter.ConvertFromString(colors.SidebarColor)), new Color?((Color)ColorConverter.ConvertFromString(colors.LightSuccessColor)), new Color?((Color)ColorConverter.ConvertFromString(colors.SuccessColor)), new Color?((Color)ColorConverter.ConvertFromString(colors.DarkSuccessColor)), new Color?((Color)ColorConverter.ConvertFromString(colors.LightDangerColor)), new Color?((Color)ColorConverter.ConvertFromString(colors.DangerColor)), new Color?((Color)ColorConverter.ConvertFromString(colors.DarkDangerColor)), new Color?((Color)ColorConverter.ConvertFromString(colors.LightInfoColor)), new Color?((Color)ColorConverter.ConvertFromString(colors.InfoColor)), new Color?((Color)ColorConverter.ConvertFromString(colors.DarkInfoColor)), new Color?((Color)ColorConverter.ConvertFromString(colors.LightWarningColor)), new Color?((Color)ColorConverter.ConvertFromString(colors.WarningColor)), new Color?((Color)ColorConverter.ConvertFromString(colors.DarkWarningColor)));
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00008276 File Offset: 0x00008276
		public static void SetColorResource(string key, Color color)
		{
			Application.Current.Resources[key] = new SolidColorBrush(color);
		}

		// Token: 0x06000160 RID: 352 RVA: 0x0000828E File Offset: 0x0000828E
		public static void SetGradientResource(string key, Color startColor, Color endColor, double angle)
		{
			Application.Current.Resources[key] = new LinearGradientBrush(startColor, endColor, angle);
		}

		// Token: 0x06000161 RID: 353 RVA: 0x000082A8 File Offset: 0x000082A8
		public static object GetResource(string key)
		{
			return Application.Current.Resources[key];
		}

		// Token: 0x02000050 RID: 80
		public class CustomBackground : INotifyPropertyChanged
		{
			// Token: 0x14000001 RID: 1
			// (add) Token: 0x06000219 RID: 537 RVA: 0x0000A964 File Offset: 0x0000A964
			// (remove) Token: 0x0600021A RID: 538 RVA: 0x0000A99C File Offset: 0x0000A99C
			public event PropertyChangedEventHandler PropertyChanged;

			// Token: 0x0600021B RID: 539 RVA: 0x0000A9D4 File Offset: 0x0000A9D4
			public void SetImageData(byte[] data)
			{
				BitmapImage bitmapImage = new BitmapImage();
				bitmapImage.BeginInit();
				bitmapImage.StreamSource = new MemoryStream(data);
				bitmapImage.EndInit();
				this.ImageSource = bitmapImage;
			}

			// Token: 0x1700008A RID: 138
			// (get) Token: 0x0600021C RID: 540 RVA: 0x0000AA06 File Offset: 0x0000AA06
			// (set) Token: 0x0600021D RID: 541 RVA: 0x0000AA0E File Offset: 0x0000AA0E
			public ImageSource ImageSource
			{
				get
				{
					return this.imageSource;
				}
				set
				{
					this.imageSource = value;
					this.OnPropertyChanged("ImageSource");
				}
			}

			// Token: 0x0600021E RID: 542 RVA: 0x0000AA24 File Offset: 0x0000AA24
			protected void OnPropertyChanged(string name)
			{
				PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
				if (propertyChanged != null)
				{
					propertyChanged(this, new PropertyChangedEventArgs(name));
				}
			}

			// Token: 0x040001A9 RID: 425
			private ImageSource imageSource;
		}

		// Token: 0x02000051 RID: 81
		public class CustomPofilePic : INotifyPropertyChanged
		{
			// Token: 0x14000002 RID: 2
			// (add) Token: 0x06000220 RID: 544 RVA: 0x0000AA50 File Offset: 0x0000AA50
			// (remove) Token: 0x06000221 RID: 545 RVA: 0x0000AA88 File Offset: 0x0000AA88
			public event PropertyChangedEventHandler PropertyChanged;

			// Token: 0x06000222 RID: 546 RVA: 0x0000AAC0 File Offset: 0x0000AAC0
			public void SetImageData(byte[] data)
			{
				BitmapImage bitmapImage = new BitmapImage();
				bitmapImage.BeginInit();
				bitmapImage.StreamSource = new MemoryStream(data);
				bitmapImage.EndInit();
				this.ProfileSource = bitmapImage;
			}

			// Token: 0x1700008B RID: 139
			// (get) Token: 0x06000223 RID: 547 RVA: 0x0000AAF2 File Offset: 0x0000AAF2
			// (set) Token: 0x06000224 RID: 548 RVA: 0x0000AAFA File Offset: 0x0000AAFA
			public ImageSource ProfileSource
			{
				get
				{
					return this.profileSource;
				}
				set
				{
					this.profileSource = value;
					this.OnPropertyChanged("ProfileSource");
				}
			}

			// Token: 0x06000225 RID: 549 RVA: 0x0000AB10 File Offset: 0x0000AB10
			protected void OnPropertyChanged(string name)
			{
				PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
				if (propertyChanged != null)
				{
					propertyChanged(this, new PropertyChangedEventArgs(name));
				}
			}

			// Token: 0x040001AB RID: 427
			private ImageSource profileSource;
		}
	}
}
