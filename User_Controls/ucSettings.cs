using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using MaterialDesignThemes.Wpf;
using Microsoft.Win32;
using Newtonsoft.Json;
using SafeGuard;
using Synax.Includes;
using Synax.Includes.FujiPopup;

namespace Synax.User_Controls
{
	// Token: 0x02000020 RID: 32
	public class ucSettings : UserControl, IComponentConnector
	{
		// Token: 0x060000EC RID: 236 RVA: 0x00004400 File Offset: 0x00004400
		public ucSettings()
		{
			this.InitializeComponent();
			this.userlbl.Content = ResponseInformation.loginresponse.UserName;
			this.userPlan.Content = ResponseInformation.loginresponse.Email;
			this.userExpirationDate.Content = ResponseInformation.loginresponse.ExpirationDate.ToString();
			string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), SafeGuardTitle.safeguardtitle) + "\\ThemeInformation.json";
			if (!FileHelper.CheckFile(path))
			{
				ucSettings.themeObject = ThemeChanger.DefaultTheme();
				string data = JsonConvert.SerializeObject(ucSettings.themeObject, Formatting.Indented);
				if (!FileHelper.WriteFile(path, data))
				{
					msgHost.dangerBox("Failed to create file!", "The theme file couldn't be created, please relaunch!", 5);
				}
			}
			else
			{
				ucSettings.themeObject = JsonConvert.DeserializeObject<ThemeObject>(File.ReadAllText(path));
			}
			if (SettingsManager.Load().AutoLogin)
			{
				this.tgAutoLogin.IsChecked = new bool?(true);
			}
			this.cbLogManagement.Items.Add("Clear Attacks");
			this.cbThemeOptions.Items.Add("Import Theme");
			this.cbThemeOptions.Items.Add("Export Theme");
			this.cbThemeOptions.Items.Add("Reset Theme");
		}

		// Token: 0x060000ED RID: 237 RVA: 0x0000453C File Offset: 0x0000453C
		private Color SolidColorBrushToColor(SolidColorBrush solidColorBrush)
		{
			return Color.FromArgb(solidColorBrush.Color.A, solidColorBrush.Color.R, solidColorBrush.Color.G, solidColorBrush.Color.B);
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00004588 File Offset: 0x00004588
		private string ColorToHex(Color c)
		{
			return string.Concat(new string[]
			{
				"#",
				c.A.ToString("X2"),
				c.R.ToString("X2"),
				c.G.ToString("X2"),
				c.B.ToString("X2")
			});
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00004604 File Offset: 0x00004604
		private void SaveTheme()
		{
			string contents = JsonConvert.SerializeObject(ucSettings.themeObject, Formatting.Indented);
			File.WriteAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), SafeGuardTitle.safeguardtitle) + "\\ThemeInformation.json", contents);
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00004640 File Offset: 0x00004640
		private void EditColor(object sender, RoutedEventArgs e)
		{
			string name = ((Button)sender).Name;
			uint num = <PrivateImplementationDetails>.ComputeStringHash(name);
			if (num <= 1835589579U)
			{
				if (num <= 925056418U)
				{
					if (num <= 317039901U)
					{
						if (num != 117199900U)
						{
							if (num != 268127980U)
							{
								if (num != 317039901U)
								{
									return;
								}
								if (!(name == "btnSuccessColor"))
								{
									return;
								}
								ucSettings.StyleKey = "SuccessColor";
								this.lblColorName.Content = "Success";
								this.lblColorName.SetResourceReference(Control.ForegroundProperty, ucSettings.StyleKey);
								this.colorZone.SetResourceReference(Control.BackgroundProperty, ucSettings.StyleKey);
								this.colorPicker.Color = this.SolidColorBrushToColor((SolidColorBrush)Application.Current.Resources[ucSettings.StyleKey]);
								this.bColorEditor.Visibility = Visibility.Visible;
								this.pnlPopup.Visibility = Visibility.Visible;
								return;
							}
							else
							{
								if (!(name == "btnLightInfoColor"))
								{
									return;
								}
								ucSettings.StyleKey = "LightInfoColor";
								this.lblColorName.Content = "Light Info";
								this.lblColorName.SetResourceReference(Control.ForegroundProperty, ucSettings.StyleKey);
								this.colorZone.SetResourceReference(Control.BackgroundProperty, ucSettings.StyleKey);
								this.colorPicker.Color = this.SolidColorBrushToColor((SolidColorBrush)Application.Current.Resources[ucSettings.StyleKey]);
								this.bColorEditor.Visibility = Visibility.Visible;
								this.pnlPopup.Visibility = Visibility.Visible;
								return;
							}
						}
						else
						{
							if (!(name == "btnSidebarColor"))
							{
								return;
							}
							ucSettings.StyleKey = "SidebarColor";
							this.lblColorName.Content = "Sidebar";
							this.lblColorName.SetResourceReference(Control.ForegroundProperty, ucSettings.StyleKey);
							this.colorZone.SetResourceReference(Control.BackgroundProperty, ucSettings.StyleKey);
							this.colorPicker.Color = this.SolidColorBrushToColor((SolidColorBrush)Application.Current.Resources[ucSettings.StyleKey]);
							this.bColorEditor.Visibility = Visibility.Visible;
							this.pnlPopup.Visibility = Visibility.Visible;
							return;
						}
					}
					else if (num != 377364870U)
					{
						if (num != 540862734U)
						{
							if (num != 925056418U)
							{
								return;
							}
							if (!(name == "btnLightWarningColor"))
							{
								return;
							}
							ucSettings.StyleKey = "LightWarningColor";
							this.lblColorName.Content = "Light Warning";
							this.lblColorName.SetResourceReference(Control.ForegroundProperty, ucSettings.StyleKey);
							this.colorZone.SetResourceReference(Control.BackgroundProperty, ucSettings.StyleKey);
							this.colorPicker.Color = this.SolidColorBrushToColor((SolidColorBrush)Application.Current.Resources[ucSettings.StyleKey]);
							this.bColorEditor.Visibility = Visibility.Visible;
							this.pnlPopup.Visibility = Visibility.Visible;
							return;
						}
						else
						{
							if (!(name == "btnPrimaryDataColor"))
							{
								return;
							}
							ucSettings.StyleKey = "PrimaryDataColor";
							this.lblColorName.Content = "Primary";
							this.lblColorName.SetResourceReference(Control.ForegroundProperty, ucSettings.StyleKey);
							this.colorZone.SetResourceReference(Control.BackgroundProperty, ucSettings.StyleKey);
							this.colorPicker.Color = this.SolidColorBrushToColor((SolidColorBrush)Application.Current.Resources[ucSettings.StyleKey]);
							this.bColorEditor.Visibility = Visibility.Visible;
							this.pnlPopup.Visibility = Visibility.Visible;
							return;
						}
					}
					else
					{
						if (!(name == "btnDarkerDangerColor"))
						{
							return;
						}
						ucSettings.StyleKey = "DarkDangerColor";
						this.lblColorName.Content = "Dark Danger";
						this.lblColorName.SetResourceReference(Control.ForegroundProperty, ucSettings.StyleKey);
						this.colorZone.SetResourceReference(Control.BackgroundProperty, ucSettings.StyleKey);
						this.colorPicker.Color = this.SolidColorBrushToColor((SolidColorBrush)Application.Current.Resources[ucSettings.StyleKey]);
						this.bColorEditor.Visibility = Visibility.Visible;
						this.pnlPopup.Visibility = Visibility.Visible;
						return;
					}
				}
				else if (num <= 1114673452U)
				{
					if (num != 1024300276U)
					{
						if (num != 1059267073U)
						{
							if (num != 1114673452U)
							{
								return;
							}
							if (!(name == "btnDarkWarningColor"))
							{
								return;
							}
							ucSettings.StyleKey = "DarkWarningColor";
							this.lblColorName.Content = "Dark Warning";
							this.lblColorName.SetResourceReference(Control.ForegroundProperty, ucSettings.StyleKey);
							this.colorZone.SetResourceReference(Control.BackgroundProperty, ucSettings.StyleKey);
							this.colorPicker.Color = this.SolidColorBrushToColor((SolidColorBrush)Application.Current.Resources[ucSettings.StyleKey]);
							this.bColorEditor.Visibility = Visibility.Visible;
							this.pnlPopup.Visibility = Visibility.Visible;
							return;
						}
						else
						{
							if (!(name == "btnMainBackgroundColor"))
							{
								return;
							}
							ucSettings.StyleKey = "MainBackgroundColor";
							this.lblColorName.Content = "Main Background";
							this.lblColorName.SetResourceReference(Control.ForegroundProperty, ucSettings.StyleKey);
							this.colorZone.SetResourceReference(Control.BackgroundProperty, ucSettings.StyleKey);
							this.colorPicker.Color = this.SolidColorBrushToColor((SolidColorBrush)Application.Current.Resources[ucSettings.StyleKey]);
							this.bColorEditor.Visibility = Visibility.Visible;
							this.pnlPopup.Visibility = Visibility.Visible;
							return;
						}
					}
					else
					{
						if (!(name == "btnWarningColor"))
						{
							return;
						}
						ucSettings.StyleKey = "WarningColor";
						this.lblColorName.Content = "Warning";
						this.lblColorName.SetResourceReference(Control.ForegroundProperty, ucSettings.StyleKey);
						this.colorZone.SetResourceReference(Control.BackgroundProperty, ucSettings.StyleKey);
						this.colorPicker.Color = this.SolidColorBrushToColor((SolidColorBrush)Application.Current.Resources[ucSettings.StyleKey]);
						this.bColorEditor.Visibility = Visibility.Visible;
						this.pnlPopup.Visibility = Visibility.Visible;
						return;
					}
				}
				else if (num <= 1329227291U)
				{
					if (num != 1251432068U)
					{
						if (num != 1329227291U)
						{
							return;
						}
						if (!(name == "btnDangerColor"))
						{
							return;
						}
						ucSettings.StyleKey = "DangerColor";
						this.lblColorName.Content = "Danger";
						this.lblColorName.SetResourceReference(Control.ForegroundProperty, ucSettings.StyleKey);
						this.colorZone.SetResourceReference(Control.BackgroundProperty, ucSettings.StyleKey);
						this.colorPicker.Color = this.SolidColorBrushToColor((SolidColorBrush)Application.Current.Resources[ucSettings.StyleKey]);
						this.bColorEditor.Visibility = Visibility.Visible;
						this.pnlPopup.Visibility = Visibility.Visible;
						return;
					}
					else
					{
						if (!(name == "btnDarkerHeaderColor"))
						{
							return;
						}
						ucSettings.StyleKey = "HeaderDarkerColor";
						this.lblColorName.Content = "Header Dark";
						this.lblColorName.SetResourceReference(Control.ForegroundProperty, ucSettings.StyleKey);
						this.colorZone.SetResourceReference(Control.BackgroundProperty, ucSettings.StyleKey);
						this.colorPicker.Color = this.SolidColorBrushToColor((SolidColorBrush)Application.Current.Resources[ucSettings.StyleKey]);
						this.bColorEditor.Visibility = Visibility.Visible;
						this.pnlPopup.Visibility = Visibility.Visible;
						return;
					}
				}
				else if (num != 1600265865U)
				{
					if (num != 1835589579U)
					{
						return;
					}
					if (!(name == "btnLabelLowerColor"))
					{
						return;
					}
					ucSettings.StyleKey = "LabelLowerColor";
					this.lblColorName.Content = "Label Lower";
					this.lblColorName.SetResourceReference(Control.ForegroundProperty, ucSettings.StyleKey);
					this.colorZone.SetResourceReference(Control.BackgroundProperty, ucSettings.StyleKey);
					this.colorPicker.Color = this.SolidColorBrushToColor((SolidColorBrush)Application.Current.Resources[ucSettings.StyleKey]);
					this.bColorEditor.Visibility = Visibility.Visible;
					this.pnlPopup.Visibility = Visibility.Visible;
					return;
				}
				else
				{
					if (!(name == "btnLabelHeaderColor"))
					{
						return;
					}
					ucSettings.StyleKey = "LabelHeaderColor";
					this.lblColorName.Content = "Label Header";
					this.lblColorName.SetResourceReference(Control.ForegroundProperty, ucSettings.StyleKey);
					this.colorZone.SetResourceReference(Control.BackgroundProperty, ucSettings.StyleKey);
					this.colorPicker.Color = this.SolidColorBrushToColor((SolidColorBrush)Application.Current.Resources[ucSettings.StyleKey]);
					this.bColorEditor.Visibility = Visibility.Visible;
					this.pnlPopup.Visibility = Visibility.Visible;
					return;
				}
			}
			else if (num <= 2543349526U)
			{
				if (num <= 2228892161U)
				{
					if (num != 2059695866U)
					{
						if (num != 2140177490U)
						{
							if (num != 2228892161U)
							{
								return;
							}
							if (!(name == "btnIconBackgroundColor"))
							{
								return;
							}
							ucSettings.StyleKey = "IconBackgroundColor";
							this.lblColorName.Content = "Icon Background";
							this.lblColorName.SetResourceReference(Control.ForegroundProperty, ucSettings.StyleKey);
							this.colorZone.SetResourceReference(Control.BackgroundProperty, ucSettings.StyleKey);
							this.colorPicker.Color = this.SolidColorBrushToColor((SolidColorBrush)Application.Current.Resources[ucSettings.StyleKey]);
							this.bColorEditor.Visibility = Visibility.Visible;
							this.pnlPopup.Visibility = Visibility.Visible;
							return;
						}
						else
						{
							if (!(name == "btnInfoColor"))
							{
								return;
							}
							ucSettings.StyleKey = "InfoColor";
							this.lblColorName.Content = "Info";
							this.lblColorName.SetResourceReference(Control.ForegroundProperty, ucSettings.StyleKey);
							this.colorZone.SetResourceReference(Control.BackgroundProperty, ucSettings.StyleKey);
							this.colorPicker.Color = this.SolidColorBrushToColor((SolidColorBrush)Application.Current.Resources[ucSettings.StyleKey]);
							this.bColorEditor.Visibility = Visibility.Visible;
							this.pnlPopup.Visibility = Visibility.Visible;
							return;
						}
					}
					else
					{
						if (!(name == "btnDarkInfoColor"))
						{
							return;
						}
						ucSettings.StyleKey = "DarkInfoColor";
						this.lblColorName.Content = "Dark Info";
						this.lblColorName.SetResourceReference(Control.ForegroundProperty, ucSettings.StyleKey);
						this.colorZone.SetResourceReference(Control.BackgroundProperty, ucSettings.StyleKey);
						this.colorPicker.Color = this.SolidColorBrushToColor((SolidColorBrush)Application.Current.Resources[ucSettings.StyleKey]);
						this.bColorEditor.Visibility = Visibility.Visible;
						this.pnlPopup.Visibility = Visibility.Visible;
						return;
					}
				}
				else if (num <= 2347980833U)
				{
					if (num != 2325615677U)
					{
						if (num != 2347980833U)
						{
							return;
						}
						if (!(name == "btnHeaderColor"))
						{
							return;
						}
						ucSettings.StyleKey = "HeaderColor";
						this.lblColorName.Content = "Header";
						this.lblColorName.SetResourceReference(Control.ForegroundProperty, ucSettings.StyleKey);
						this.colorZone.SetResourceReference(Control.BackgroundProperty, ucSettings.StyleKey);
						this.colorPicker.Color = this.SolidColorBrushToColor((SolidColorBrush)Application.Current.Resources[ucSettings.StyleKey]);
						this.bColorEditor.Visibility = Visibility.Visible;
						this.pnlPopup.Visibility = Visibility.Visible;
						return;
					}
					else
					{
						if (!(name == "btnLightDangerColor"))
						{
							return;
						}
						ucSettings.StyleKey = "LightDangerColor";
						this.lblColorName.Content = "Light Danger";
						this.lblColorName.SetResourceReference(Control.ForegroundProperty, ucSettings.StyleKey);
						this.colorZone.SetResourceReference(Control.BackgroundProperty, ucSettings.StyleKey);
						this.colorPicker.Color = this.SolidColorBrushToColor((SolidColorBrush)Application.Current.Resources[ucSettings.StyleKey]);
						this.bColorEditor.Visibility = Visibility.Visible;
						this.pnlPopup.Visibility = Visibility.Visible;
						return;
					}
				}
				else if (num != 2414377927U)
				{
					if (num != 2543349526U)
					{
						return;
					}
					if (!(name == "btnGridBackgroundColor"))
					{
						return;
					}
					ucSettings.StyleKey = "GridBackgroundColor";
					this.lblColorName.Content = "Grid Background";
					this.lblColorName.SetResourceReference(Control.ForegroundProperty, ucSettings.StyleKey);
					this.colorZone.SetResourceReference(Control.BackgroundProperty, ucSettings.StyleKey);
					this.colorPicker.Color = this.SolidColorBrushToColor((SolidColorBrush)Application.Current.Resources[ucSettings.StyleKey]);
					this.bColorEditor.Visibility = Visibility.Visible;
					this.pnlPopup.Visibility = Visibility.Visible;
					return;
				}
				else
				{
					if (!(name == "btnTextColor"))
					{
						return;
					}
					ucSettings.StyleKey = "TextColor";
					this.lblColorName.Content = "Text";
					this.lblColorName.SetResourceReference(Control.ForegroundProperty, ucSettings.StyleKey);
					this.colorZone.SetResourceReference(Control.BackgroundProperty, ucSettings.StyleKey);
					this.colorPicker.Color = this.SolidColorBrushToColor((SolidColorBrush)Application.Current.Resources[ucSettings.StyleKey]);
					this.bColorEditor.Visibility = Visibility.Visible;
					this.pnlPopup.Visibility = Visibility.Visible;
					return;
				}
			}
			else if (num <= 3763621274U)
			{
				if (num != 3285485696U)
				{
					if (num != 3744703631U)
					{
						if (num != 3763621274U)
						{
							return;
						}
						if (!(name == "btnBackgroundColor"))
						{
							return;
						}
						ucSettings.StyleKey = "ButtonBackgroundColor";
						this.lblColorName.Content = "Button Background";
						this.lblColorName.SetResourceReference(Control.ForegroundProperty, ucSettings.StyleKey);
						this.colorZone.SetResourceReference(Control.BackgroundProperty, ucSettings.StyleKey);
						this.colorPicker.Color = this.SolidColorBrushToColor((SolidColorBrush)Application.Current.Resources[ucSettings.StyleKey]);
						this.bColorEditor.Visibility = Visibility.Visible;
						this.pnlPopup.Visibility = Visibility.Visible;
						return;
					}
					else
					{
						if (!(name == "btnMain2BackgroundColor"))
						{
							return;
						}
						ucSettings.StyleKey = "SecondaryBackgroundColor";
						this.lblColorName.Content = "Main-2 Background";
						this.lblColorName.SetResourceReference(Control.ForegroundProperty, ucSettings.StyleKey);
						this.colorZone.SetResourceReference(Control.BackgroundProperty, ucSettings.StyleKey);
						this.colorPicker.Color = this.SolidColorBrushToColor((SolidColorBrush)Application.Current.Resources[ucSettings.StyleKey]);
						this.bColorEditor.Visibility = Visibility.Visible;
						this.pnlPopup.Visibility = Visibility.Visible;
						return;
					}
				}
				else
				{
					if (!(name == "btnButtonForgroundColor"))
					{
						return;
					}
					ucSettings.StyleKey = "ButtonForegroundColor";
					this.lblColorName.Content = "Button Forground";
					this.lblColorName.SetResourceReference(Control.ForegroundProperty, ucSettings.StyleKey);
					this.colorZone.SetResourceReference(Control.BackgroundProperty, ucSettings.StyleKey);
					this.colorPicker.Color = this.SolidColorBrushToColor((SolidColorBrush)Application.Current.Resources[ucSettings.StyleKey]);
					this.bColorEditor.Visibility = Visibility.Visible;
					this.pnlPopup.Visibility = Visibility.Visible;
					return;
				}
			}
			else if (num <= 4033128197U)
			{
				if (num != 4010399246U)
				{
					if (num != 4033128197U)
					{
						return;
					}
					if (!(name == "btnDarkSuccessColor"))
					{
						return;
					}
					ucSettings.StyleKey = "DarkSuccessColor";
					this.lblColorName.Content = "Dark Success";
					this.lblColorName.SetResourceReference(Control.ForegroundProperty, ucSettings.StyleKey);
					this.colorZone.SetResourceReference(Control.BackgroundProperty, ucSettings.StyleKey);
					this.colorPicker.Color = this.SolidColorBrushToColor((SolidColorBrush)Application.Current.Resources[ucSettings.StyleKey]);
					this.bColorEditor.Visibility = Visibility.Visible;
					this.pnlPopup.Visibility = Visibility.Visible;
					return;
				}
				else
				{
					if (!(name == "btnTitleColor"))
					{
						return;
					}
					ucSettings.StyleKey = "TitleColor";
					this.lblColorName.Content = "Title";
					this.lblColorName.SetResourceReference(Control.ForegroundProperty, ucSettings.StyleKey);
					this.colorZone.SetResourceReference(Control.BackgroundProperty, ucSettings.StyleKey);
					this.colorPicker.Color = this.SolidColorBrushToColor((SolidColorBrush)Application.Current.Resources[ucSettings.StyleKey]);
					this.bColorEditor.Visibility = Visibility.Visible;
					this.pnlPopup.Visibility = Visibility.Visible;
					return;
				}
			}
			else if (num != 4193138249U)
			{
				if (num != 4216211771U)
				{
					return;
				}
				if (!(name == "btnLightSuccessColor"))
				{
					return;
				}
				ucSettings.StyleKey = "LightSuccessColor";
				this.lblColorName.Content = "Light Success";
				this.lblColorName.SetResourceReference(Control.ForegroundProperty, ucSettings.StyleKey);
				this.colorZone.SetResourceReference(Control.BackgroundProperty, ucSettings.StyleKey);
				this.colorPicker.Color = this.SolidColorBrushToColor((SolidColorBrush)Application.Current.Resources[ucSettings.StyleKey]);
				this.bColorEditor.Visibility = Visibility.Visible;
				this.pnlPopup.Visibility = Visibility.Visible;
				return;
			}
			else
			{
				if (!(name == "btnIconForgroundColor"))
				{
					return;
				}
				ucSettings.StyleKey = "IconForegroundColor";
				this.lblColorName.Content = "Icon Forground";
				this.lblColorName.SetResourceReference(Control.ForegroundProperty, ucSettings.StyleKey);
				this.colorZone.SetResourceReference(Control.BackgroundProperty, ucSettings.StyleKey);
				this.colorPicker.Color = this.SolidColorBrushToColor((SolidColorBrush)Application.Current.Resources[ucSettings.StyleKey]);
				this.bColorEditor.Visibility = Visibility.Visible;
				this.pnlPopup.Visibility = Visibility.Visible;
				return;
			}
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x000057E8 File Offset: 0x000057E8
		private void tbCustomColor_TextChanged(object sender, TextChangedEventArgs e)
		{
			try
			{
				Color color = (Color)ColorConverter.ConvertFromString(this.tbCustomColor.Text);
				Application.Current.Resources[ucSettings.StyleKey] = new SolidColorBrush(color);
				string styleKey = ucSettings.StyleKey;
				uint num = <PrivateImplementationDetails>.ComputeStringHash(styleKey);
				if (num <= 2003922388U)
				{
					if (num <= 1231938661U)
					{
						if (num <= 616509356U)
						{
							if (num != 149105539U)
							{
								if (num != 328716378U)
								{
									if (num == 616509356U)
									{
										if (styleKey == "PrimaryDataColor")
										{
											ucSettings.themeObject.Colors.PrimaryDataColor = this.ColorToHex(color);
										}
									}
								}
								else if (styleKey == "LightInfoColor")
								{
									ucSettings.themeObject.Colors.LightInfoColor = this.ColorToHex(color);
								}
							}
							else if (styleKey == "LightDangerColor")
							{
								ucSettings.themeObject.Colors.LightDangerColor = this.ColorToHex(color);
							}
						}
						else if (num != 1005921420U)
						{
							if (num != 1101727415U)
							{
								if (num == 1231938661U)
								{
									if (styleKey == "LightSuccessColor")
									{
										ucSettings.themeObject.Colors.LightSuccessColor = this.ColorToHex(color);
									}
								}
							}
							else if (styleKey == "HeaderColor")
							{
								ucSettings.themeObject.Colors.HeaderColor = this.ColorToHex(color);
							}
						}
						else if (styleKey == "LightWarningColor")
						{
							ucSettings.themeObject.Colors.LightWarningColor = this.ColorToHex(color);
						}
					}
					else if (num <= 1377366855U)
					{
						if (num != 1312053912U)
						{
							if (num != 1363248094U)
							{
								if (num == 1377366855U)
								{
									if (styleKey == "DarkSuccessColor")
									{
										ucSettings.themeObject.Colors.DarkSuccessColor = this.ColorToHex(color);
									}
								}
							}
							else if (styleKey == "DarkWarningColor")
							{
								ucSettings.themeObject.Colors.DarkWarningColor = this.ColorToHex(color);
							}
						}
						else if (styleKey == "InfoColor")
						{
							ucSettings.themeObject.Colors.InfoColor = this.ColorToHex(color);
						}
					}
					else if (num <= 1683096287U)
					{
						if (num != 1618149816U)
						{
							if (num == 1683096287U)
							{
								if (styleKey == "LabelHeaderColor")
								{
									ucSettings.themeObject.Colors.LabelHeaderColor = this.ColorToHex(color);
								}
							}
						}
						else if (styleKey == "DarkInfoColor")
						{
							ucSettings.themeObject.Colors.DarkInfoColor = this.ColorToHex(color);
						}
					}
					else if (num != 1784420707U)
					{
						if (num == 2003922388U)
						{
							if (styleKey == "ButtonBackgroundColor")
							{
								ucSettings.themeObject.Colors.ButtonBackgroundColor = this.ColorToHex(color);
							}
						}
					}
					else if (styleKey == "MainBackgroundColor")
					{
						ucSettings.themeObject.Colors.MainBackgroundColor = this.ColorToHex(color);
					}
				}
				else if (num <= 3095533300U)
				{
					if (num <= 2268959076U)
					{
						if (num != 2066341971U)
						{
							if (num != 2248204990U)
							{
								if (num == 2268959076U)
								{
									if (styleKey == "IconForegroundColor")
									{
										ucSettings.themeObject.Colors.IconForegroundColor = this.ColorToHex(color);
									}
								}
							}
							else if (styleKey == "WarningColor")
							{
								ucSettings.themeObject.Colors.WarningColor = this.ColorToHex(color);
							}
						}
						else if (styleKey == "ButtonForegroundColor")
						{
							ucSettings.themeObject.Colors.ButtonForegroundColor = this.ColorToHex(color);
						}
					}
					else if (num <= 2675163559U)
					{
						if (num != 2527699425U)
						{
							if (num == 2675163559U)
							{
								if (styleKey == "SuccessColor")
								{
									ucSettings.themeObject.Colors.SuccessColor = this.ColorToHex(color);
								}
							}
						}
						else if (styleKey == "TextColor")
						{
							ucSettings.themeObject.Colors.TextColor = this.ColorToHex(color);
						}
					}
					else if (num != 2827349132U)
					{
						if (num == 3095533300U)
						{
							if (styleKey == "GridBackgroundColor")
							{
								ucSettings.themeObject.Colors.GridBackgroundColor = this.ColorToHex(color);
							}
						}
					}
					else if (styleKey == "TitleColor")
					{
						ucSettings.themeObject.Colors.TitleColor = this.ColorToHex(color);
					}
				}
				else if (num <= 3508650676U)
				{
					if (num != 3212993243U)
					{
						if (num != 3389858698U)
						{
							if (num == 3508650676U)
							{
								if (styleKey == "SecondaryBackgroundColor")
								{
									ucSettings.themeObject.Colors.SecondaryBackgroundColor = this.ColorToHex(color);
								}
							}
						}
						else if (styleKey == "HeaderDarkerColor")
						{
							ucSettings.themeObject.Colors.HeaderDarkerColor = this.ColorToHex(color);
						}
					}
					else if (styleKey == "IconBackgroundColor")
					{
						ucSettings.themeObject.Colors.IconBackgroundColor = this.ColorToHex(color);
					}
				}
				else if (num <= 3739125654U)
				{
					if (num != 3531631733U)
					{
						if (num == 3739125654U)
						{
							if (styleKey == "SidebarColor")
							{
								ucSettings.themeObject.Colors.SidebarColor = this.ColorToHex(color);
							}
						}
					}
					else if (styleKey == "LabelLowerColor")
					{
						ucSettings.themeObject.Colors.LabelLowerColor = this.ColorToHex(color);
					}
				}
				else if (num != 3770381521U)
				{
					if (num == 3802873969U)
					{
						if (styleKey == "DarkDangerColor")
						{
							ucSettings.themeObject.Colors.DarkDangerColor = this.ColorToHex(color);
						}
					}
				}
				else if (styleKey == "DangerColor")
				{
					ucSettings.themeObject.Colors.DangerColor = this.ColorToHex(color);
				}
			}
			catch
			{
				msgHost.dangerBox("Unknown Error", "Failed to complete task.", 5);
			}
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00005F0C File Offset: 0x00005F0C
		private void ClosePopup(object sender, RoutedEventArgs e)
		{
			this.pnlPopup.Visibility = Visibility.Hidden;
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00005F1C File Offset: 0x00005F1C
		private void ChangeColor(object sender, MouseButtonEventArgs e)
		{
			Color color = this.colorPicker.Color;
			Application.Current.Resources[ucSettings.StyleKey] = new SolidColorBrush(color);
			string styleKey = ucSettings.StyleKey;
			uint num = <PrivateImplementationDetails>.ComputeStringHash(styleKey);
			if (num <= 2003922388U)
			{
				if (num <= 1231938661U)
				{
					if (num <= 616509356U)
					{
						if (num != 149105539U)
						{
							if (num != 328716378U)
							{
								if (num == 616509356U)
								{
									if (styleKey == "PrimaryDataColor")
									{
										ucSettings.themeObject.Colors.PrimaryDataColor = this.ColorToHex(color);
									}
								}
							}
							else if (styleKey == "LightInfoColor")
							{
								ucSettings.themeObject.Colors.LightInfoColor = this.ColorToHex(color);
							}
						}
						else if (styleKey == "LightDangerColor")
						{
							ucSettings.themeObject.Colors.LightDangerColor = this.ColorToHex(color);
						}
					}
					else if (num != 1005921420U)
					{
						if (num != 1101727415U)
						{
							if (num == 1231938661U)
							{
								if (styleKey == "LightSuccessColor")
								{
									ucSettings.themeObject.Colors.LightSuccessColor = this.ColorToHex(color);
								}
							}
						}
						else if (styleKey == "HeaderColor")
						{
							ucSettings.themeObject.Colors.HeaderColor = this.ColorToHex(color);
						}
					}
					else if (styleKey == "LightWarningColor")
					{
						ucSettings.themeObject.Colors.LightWarningColor = this.ColorToHex(color);
					}
				}
				else if (num <= 1377366855U)
				{
					if (num != 1312053912U)
					{
						if (num != 1363248094U)
						{
							if (num == 1377366855U)
							{
								if (styleKey == "DarkSuccessColor")
								{
									ucSettings.themeObject.Colors.DarkSuccessColor = this.ColorToHex(color);
								}
							}
						}
						else if (styleKey == "DarkWarningColor")
						{
							ucSettings.themeObject.Colors.DarkWarningColor = this.ColorToHex(color);
						}
					}
					else if (styleKey == "InfoColor")
					{
						ucSettings.themeObject.Colors.InfoColor = this.ColorToHex(color);
					}
				}
				else if (num <= 1683096287U)
				{
					if (num != 1618149816U)
					{
						if (num == 1683096287U)
						{
							if (styleKey == "LabelHeaderColor")
							{
								ucSettings.themeObject.Colors.LabelHeaderColor = this.ColorToHex(color);
							}
						}
					}
					else if (styleKey == "DarkInfoColor")
					{
						ucSettings.themeObject.Colors.DarkInfoColor = this.ColorToHex(color);
					}
				}
				else if (num != 1784420707U)
				{
					if (num == 2003922388U)
					{
						if (styleKey == "ButtonBackgroundColor")
						{
							ucSettings.themeObject.Colors.ButtonBackgroundColor = this.ColorToHex(color);
						}
					}
				}
				else if (styleKey == "MainBackgroundColor")
				{
					ucSettings.themeObject.Colors.MainBackgroundColor = this.ColorToHex(color);
				}
			}
			else if (num <= 3095533300U)
			{
				if (num <= 2268959076U)
				{
					if (num != 2066341971U)
					{
						if (num != 2248204990U)
						{
							if (num == 2268959076U)
							{
								if (styleKey == "IconForegroundColor")
								{
									ucSettings.themeObject.Colors.IconForegroundColor = this.ColorToHex(color);
								}
							}
						}
						else if (styleKey == "WarningColor")
						{
							ucSettings.themeObject.Colors.WarningColor = this.ColorToHex(color);
						}
					}
					else if (styleKey == "ButtonForegroundColor")
					{
						ucSettings.themeObject.Colors.ButtonForegroundColor = this.ColorToHex(color);
					}
				}
				else if (num <= 2675163559U)
				{
					if (num != 2527699425U)
					{
						if (num == 2675163559U)
						{
							if (styleKey == "SuccessColor")
							{
								ucSettings.themeObject.Colors.SuccessColor = this.ColorToHex(color);
							}
						}
					}
					else if (styleKey == "TextColor")
					{
						ucSettings.themeObject.Colors.TextColor = this.ColorToHex(color);
					}
				}
				else if (num != 2827349132U)
				{
					if (num == 3095533300U)
					{
						if (styleKey == "GridBackgroundColor")
						{
							ucSettings.themeObject.Colors.GridBackgroundColor = this.ColorToHex(color);
						}
					}
				}
				else if (styleKey == "TitleColor")
				{
					ucSettings.themeObject.Colors.TitleColor = this.ColorToHex(color);
				}
			}
			else if (num <= 3508650676U)
			{
				if (num != 3212993243U)
				{
					if (num != 3389858698U)
					{
						if (num == 3508650676U)
						{
							if (styleKey == "SecondaryBackgroundColor")
							{
								ucSettings.themeObject.Colors.SecondaryBackgroundColor = this.ColorToHex(color);
							}
						}
					}
					else if (styleKey == "HeaderDarkerColor")
					{
						ucSettings.themeObject.Colors.HeaderDarkerColor = this.ColorToHex(color);
					}
				}
				else if (styleKey == "IconBackgroundColor")
				{
					ucSettings.themeObject.Colors.IconBackgroundColor = this.ColorToHex(color);
				}
			}
			else if (num <= 3739125654U)
			{
				if (num != 3531631733U)
				{
					if (num == 3739125654U)
					{
						if (styleKey == "SidebarColor")
						{
							ucSettings.themeObject.Colors.SidebarColor = this.ColorToHex(color);
						}
					}
				}
				else if (styleKey == "LabelLowerColor")
				{
					ucSettings.themeObject.Colors.LabelLowerColor = this.ColorToHex(color);
				}
			}
			else if (num != 3770381521U)
			{
				if (num == 3802873969U)
				{
					if (styleKey == "DarkDangerColor")
					{
						ucSettings.themeObject.Colors.DarkDangerColor = this.ColorToHex(color);
					}
				}
			}
			else if (styleKey == "DangerColor")
			{
				ucSettings.themeObject.Colors.DangerColor = this.ColorToHex(color);
			}
			Task.Run(delegate()
			{
				this.SaveTheme();
			});
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00006618 File Offset: 0x00006618
		private void cbThemeOptions_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog
			{
				Title = SafeGuardTitle.safeguardtitle + " - Import Theme...",
				InitialDirectory = Environment.SpecialFolder.Personal.ToString(),
				Filter = "JSON File (*.json)|*.json|All Files (*.*)|*"
			};
			SaveFileDialog saveFileDialog = new SaveFileDialog
			{
				Title = SafeGuardTitle.safeguardtitle + " - Export Theme...",
				InitialDirectory = Environment.SpecialFolder.Personal.ToString(),
				Filter = "JSON File (*.json)|*.json|All Files (*.*)|*"
			};
			switch (this.cbThemeOptions.SelectedIndex)
			{
			case 0:
				try
				{
					bool? flag = openFileDialog.ShowDialog();
					bool flag2 = true;
					if (flag.GetValueOrDefault() == flag2 & flag != null)
					{
						string text = File.ReadAllText(openFileDialog.FileName);
						if (!FileHelper.WriteFile(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), SafeGuardTitle.safeguardtitle) + "\\ThemeInformation.json", text))
						{
							msgHost.dangerBox("Import Error!", "The theme couldn't be saved, try and re-import!", 5);
							return;
						}
						ThemeChanger.UpdateTheme(text);
					}
				}
				catch
				{
					msgHost.dangerBox("Import Error!", "The theme couldn't be saved, try and re-import!", 5);
					return;
				}
				msgHost.infoBox("Theme Imported", "Successfully imported your theme!", 5);
				break;
			case 1:
				try
				{
					bool? flag = saveFileDialog.ShowDialog();
					bool flag2 = true;
					if (flag.GetValueOrDefault() == flag2 & flag != null)
					{
						string data = File.ReadAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), SafeGuardTitle.safeguardtitle) + "\\ThemeInformation.json");
						if (!FileHelper.WriteFile(saveFileDialog.FileName, data))
						{
							msgHost.dangerBox("Export Error", "Failed to write the file, try and re-export!", 5);
							return;
						}
					}
				}
				catch
				{
					msgHost.dangerBox("Export Error", "Failed to write the file, try and re-export!", 5);
					return;
				}
				msgHost.infoBox("Theme Exported", "Successfully exported your theme!", 5);
				break;
			case 2:
			{
				string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), SafeGuardTitle.safeguardtitle) + "\\ThemeInformation.json";
				if (FileHelper.CheckFile(path))
				{
					ucSettings.themeObject = ThemeChanger.DefaultTheme();
					string data2 = JsonConvert.SerializeObject(ucSettings.themeObject, Formatting.Indented);
					if (!FileHelper.WriteFile(path, data2))
					{
						msgHost.dangerBox("Reset Error", "The theme file couldn't be created, please relaunch!", 5);
					}
				}
				else
				{
					ucSettings.themeObject = JsonConvert.DeserializeObject<ThemeObject>(File.ReadAllText(path));
				}
				ThemeChanger.UpdateTheme(File.ReadAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), SafeGuardTitle.safeguardtitle) + "\\ThemeInformation.json"));
				break;
			}
			}
			this.cbThemeOptions.SelectedIndex = -1;
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x000068A0 File Offset: 0x000068A0
		private void tgAutoLogin_Checked(object sender, RoutedEventArgs e)
		{
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x000068A4 File Offset: 0x000068A4
		private void cbLogManagement_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (this.cbLogManagement.SelectedIndex == 0)
			{
				string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), SafeGuardTitle.safeguardtitle) + "\\AttackLogs.json";
				try
				{
					if (File.Exists(path))
					{
						File.Delete(path);
						msgHost.infoBox("Logs Cleared!", "Your attack logs have been cleared!", 5);
					}
				}
				catch
				{
					msgHost.dangerBox("Logs Not Cleared!", "Attack logs not cleared! Unknown error.", 5);
				}
			}
			this.cbLogManagement.SelectedIndex = -1;
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00006928 File Offset: 0x00006928
		private void tgAutoLogin_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x0000692C File Offset: 0x0000692C
		private void tgAutoLogin_Click(object sender, RoutedEventArgs e)
		{
			SettingsModel settingsModel = SettingsManager.Load();
			bool? isChecked = this.tgAutoLogin.IsChecked;
			bool flag = true;
			if (isChecked.GetValueOrDefault() == flag & isChecked != null)
			{
				settingsModel.AutoLogin = true;
			}
			else
			{
				settingsModel.AutoLogin = false;
			}
			settingsModel.Save();
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00006978 File Offset: 0x00006978
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this._contentLoaded)
			{
				return;
			}
			this._contentLoaded = true;
			Uri uri = new Uri("/Synax;component/user%20controls/ucsettings.xaml", UriKind.Relative);
			Application.LoadComponent(this, uri);
		}

		// Token: 0x060000FA RID: 250 RVA: 0x000069A8 File Offset: 0x000069A8
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.userlbl = (Label)target;
				return;
			case 2:
				this.userPlan = (Label)target;
				return;
			case 3:
				this.userExpirationDate = (Label)target;
				return;
			case 4:
				this.tgAutoLogin = (ToggleButton)target;
				this.tgAutoLogin.Checked += this.tgAutoLogin_Checked;
				this.tgAutoLogin.MouseLeftButtonDown += this.tgAutoLogin_MouseLeftButtonDown;
				this.tgAutoLogin.Click += this.tgAutoLogin_Click;
				return;
			case 5:
				this.cbLogManagement = (ComboBox)target;
				this.cbLogManagement.SelectionChanged += this.cbLogManagement_SelectionChanged;
				return;
			case 6:
				this.cbThemeOptions = (ComboBox)target;
				this.cbThemeOptions.SelectionChanged += this.cbThemeOptions_SelectionChanged;
				return;
			case 7:
				this.gridPreset = (Grid)target;
				return;
			case 8:
				this.btnTitleColor = (Button)target;
				this.btnTitleColor.Click += this.EditColor;
				return;
			case 9:
				this.btnLabelHeaderColor = (Button)target;
				this.btnLabelHeaderColor.Click += this.EditColor;
				return;
			case 10:
				this.btnLabelLowerColor = (Button)target;
				this.btnLabelLowerColor.Click += this.EditColor;
				return;
			case 11:
				this.btnPrimaryDataColor = (Button)target;
				this.btnPrimaryDataColor.Click += this.EditColor;
				return;
			case 12:
				this.btnDarkerHeaderColor = (Button)target;
				this.btnDarkerHeaderColor.Click += this.EditColor;
				return;
			case 13:
				this.btnTextColor = (Button)target;
				this.btnTextColor.Click += this.EditColor;
				return;
			case 14:
				this.btnIconForgroundColor = (Button)target;
				this.btnIconForgroundColor.Click += this.EditColor;
				return;
			case 15:
				this.btnIconBackgroundColor = (Button)target;
				this.btnIconBackgroundColor.Click += this.EditColor;
				return;
			case 16:
				this.btnButtonForgroundColor = (Button)target;
				this.btnButtonForgroundColor.Click += this.EditColor;
				return;
			case 17:
				this.btnBackgroundColor = (Button)target;
				this.btnBackgroundColor.Click += this.EditColor;
				return;
			case 18:
				this.btnGridBackgroundColor = (Button)target;
				this.btnGridBackgroundColor.Click += this.EditColor;
				return;
			case 19:
				this.btnMainBackgroundColor = (Button)target;
				this.btnMainBackgroundColor.Click += this.EditColor;
				return;
			case 20:
				this.btnMain2BackgroundColor = (Button)target;
				this.btnMain2BackgroundColor.Click += this.EditColor;
				return;
			case 21:
				this.btnHeaderColor = (Button)target;
				this.btnHeaderColor.Click += this.EditColor;
				return;
			case 22:
				this.btnSidebarColor = (Button)target;
				this.btnSidebarColor.Click += this.EditColor;
				return;
			case 23:
				this.btnLightSuccessColor = (Button)target;
				this.btnLightSuccessColor.Click += this.EditColor;
				return;
			case 24:
				this.btnSuccessColor = (Button)target;
				this.btnSuccessColor.Click += this.EditColor;
				return;
			case 25:
				this.btnDarkSuccessColor = (Button)target;
				this.btnDarkSuccessColor.Click += this.EditColor;
				return;
			case 26:
				this.btnLightDangerColor = (Button)target;
				this.btnLightDangerColor.Click += this.EditColor;
				return;
			case 27:
				this.btnDangerColor = (Button)target;
				this.btnDangerColor.Click += this.EditColor;
				return;
			case 28:
				this.btnDarkerDangerColor = (Button)target;
				this.btnDarkerDangerColor.Click += this.EditColor;
				return;
			case 29:
				this.btnLightInfoColor = (Button)target;
				this.btnLightInfoColor.Click += this.EditColor;
				return;
			case 30:
				this.btnInfoColor = (Button)target;
				this.btnInfoColor.Click += this.EditColor;
				return;
			case 31:
				this.btnDarkInfoColor = (Button)target;
				this.btnDarkInfoColor.Click += this.EditColor;
				return;
			case 32:
				this.btnLightWarningColor = (Button)target;
				this.btnLightWarningColor.Click += this.EditColor;
				return;
			case 33:
				this.btnWarningColor = (Button)target;
				this.btnWarningColor.Click += this.EditColor;
				return;
			case 34:
				this.pnlPopup = (Grid)target;
				return;
			case 35:
				this.bColorEditor = (Border)target;
				return;
			case 36:
				((Button)target).Click += this.ClosePopup;
				return;
			case 37:
				this.colorZone = (ColorZone)target;
				return;
			case 38:
				this.tbCustomColor = (TextBox)target;
				this.tbCustomColor.TextChanged += this.tbCustomColor_TextChanged;
				return;
			case 39:
				this.lblColorName = (Label)target;
				return;
			case 40:
				this.colorPicker = (ColorPicker)target;
				this.colorPicker.MouseUp += this.ChangeColor;
				return;
			default:
				this._contentLoaded = true;
				return;
			}
		}

		// Token: 0x040000A2 RID: 162
		private static ThemeObject themeObject;

		// Token: 0x040000A3 RID: 163
		private static string StyleKey;

		// Token: 0x040000A4 RID: 164
		internal Label userlbl;

		// Token: 0x040000A5 RID: 165
		internal Label userPlan;

		// Token: 0x040000A6 RID: 166
		internal Label userExpirationDate;

		// Token: 0x040000A7 RID: 167
		internal ToggleButton tgAutoLogin;

		// Token: 0x040000A8 RID: 168
		internal ComboBox cbLogManagement;

		// Token: 0x040000A9 RID: 169
		internal ComboBox cbThemeOptions;

		// Token: 0x040000AA RID: 170
		internal Grid gridPreset;

		// Token: 0x040000AB RID: 171
		internal Button btnTitleColor;

		// Token: 0x040000AC RID: 172
		internal Button btnLabelHeaderColor;

		// Token: 0x040000AD RID: 173
		internal Button btnLabelLowerColor;

		// Token: 0x040000AE RID: 174
		internal Button btnPrimaryDataColor;

		// Token: 0x040000AF RID: 175
		internal Button btnDarkerHeaderColor;

		// Token: 0x040000B0 RID: 176
		internal Button btnTextColor;

		// Token: 0x040000B1 RID: 177
		internal Button btnIconForgroundColor;

		// Token: 0x040000B2 RID: 178
		internal Button btnIconBackgroundColor;

		// Token: 0x040000B3 RID: 179
		internal Button btnButtonForgroundColor;

		// Token: 0x040000B4 RID: 180
		internal Button btnBackgroundColor;

		// Token: 0x040000B5 RID: 181
		internal Button btnGridBackgroundColor;

		// Token: 0x040000B6 RID: 182
		internal Button btnMainBackgroundColor;

		// Token: 0x040000B7 RID: 183
		internal Button btnMain2BackgroundColor;

		// Token: 0x040000B8 RID: 184
		internal Button btnHeaderColor;

		// Token: 0x040000B9 RID: 185
		internal Button btnSidebarColor;

		// Token: 0x040000BA RID: 186
		internal Button btnLightSuccessColor;

		// Token: 0x040000BB RID: 187
		internal Button btnSuccessColor;

		// Token: 0x040000BC RID: 188
		internal Button btnDarkSuccessColor;

		// Token: 0x040000BD RID: 189
		internal Button btnLightDangerColor;

		// Token: 0x040000BE RID: 190
		internal Button btnDangerColor;

		// Token: 0x040000BF RID: 191
		internal Button btnDarkerDangerColor;

		// Token: 0x040000C0 RID: 192
		internal Button btnLightInfoColor;

		// Token: 0x040000C1 RID: 193
		internal Button btnInfoColor;

		// Token: 0x040000C2 RID: 194
		internal Button btnDarkInfoColor;

		// Token: 0x040000C3 RID: 195
		internal Button btnLightWarningColor;

		// Token: 0x040000C4 RID: 196
		internal Button btnWarningColor;

		// Token: 0x040000C5 RID: 197
		internal Grid pnlPopup;

		// Token: 0x040000C6 RID: 198
		internal Border bColorEditor;

		// Token: 0x040000C7 RID: 199
		internal ColorZone colorZone;

		// Token: 0x040000C8 RID: 200
		internal TextBox tbCustomColor;

		// Token: 0x040000C9 RID: 201
		internal Label lblColorName;

		// Token: 0x040000CA RID: 202
		internal ColorPicker colorPicker;

		// Token: 0x040000CB RID: 203
		private bool _contentLoaded;
	}
}
