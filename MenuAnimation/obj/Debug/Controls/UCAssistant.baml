   M S B A M L   `   `   `  ����C  ?Astmara6, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:MenuAnimado1.ControlsMenuAnimado1.Controls  5      '    !MenuAnimado1.Controls.UCAssistant   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:MenuAnimado1.Controls     5      V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      $	��484��5	      $	��746��6     � 	Resources  5
       
  Color1 
 Color3  1��%�   &	        &	 !     &	 B     ��5   
   	#FF3580BF��6*   ��5   
   	#FFF1EFEF��6*   ��5   
   	#FF3580BF��6%   5      .��5      � .+�5   
   ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  -   5          Name$ TrainsitionigContentSlide��5   .   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffect 6Q   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromLeft+   Duration$ 0:0:0.8X�.��5      �� -   5         ��Name$ cou_name��5      $
��Left=�6(   $��28��6C   $��491,157,0,0q�6O    �� TextWrapping$
 Wrap=�6d   $	��Top=�6x   $	��177��6�   .��6�   ��5      �� 5       �� Color# �  6&   .��5   &   ��5      �� 5      # �   6&   .��5   '   5      5        5   
    6/     *SlideInFromLeft+$ 0:0:0.8X�.��5      �� -   5        $ cou_nic_name��5      $
��Left=�6,   $��28��6G   $��210,157,0,0q�6S   $
 Wrap=�6h   $	��Top=�6|   $	��178��6�   .��6�   ��5      �� 5      # �  6&   .��5    &   ��5!      �� 5"      # �   6&   .��5#   '   5$      5%        5&   
    6/     *SlideInFromLeft+$ 0:0:0.8X�.��5'      �� -   5         ��Name$ degree��5'      $
��Left=�6'   $��419,217,0,0q�6B   $	��Top=�6W   $��99��6o    �� SelectedIndex$ 0��6z   $��22��6�   ��5(      �� 5)      # �  6&   ��5+      �� 5,      # �   6&   5.      5/        50   
    6/     *SlideInFromLeft+$ 0:0:0.8X�.��52      �� $��
اللقب��6   $
��Left=�6$   $��393,164,0,0q�6?   $	��Top=�6T   ��6l   Z� ��53      �� 54      # �   6&   ��56      �� 57      # �   6&   59      5:        5;   
    6/     *SlideInFromRight+$ 0:0:0.8X�.��5=      �� $��
الاسم��6   $
��Left=�6$   $��690,164,0,0q�6?   $	��Top=�6T   ��5>      �� 5?      # �   6&   5A      5B        5C   
    6/     *SlideInFromLeft+$ 0:0:0.8X�.��5E      �� $��
اضافة��6   $
��Left=�6%   $��210,293,0,0q�6@   $	��Top=�6U   $��68��6m   $��28��6x   ��5F      �� 5G      # �  6&   5I      5J        5K   
    6/     *SlideInFromLeft+$ 0:0:0.8X�.��5M      �� -   5        $��عودة��5M      $
��Left=�6$   $��	0,421,0,0q�6?   $	��Top=�6R   $��77��6j   $��29��6u   ��5N      �� 5O      # �  6&   5Q      5R        5S   
    6/     *SlideInFromLeft+$ 0:0:0.8X�.��5U      �� -   5        $��التالي��5U      $��Right=�6&   $��0,455,669,0q�6B   $	��Top=�6W   $��77��6o   $��29��6z   ��5V      �� 5W      # �  6&   5Y      5Z        5[   
    6/     *SlideInFromRight+$ 0:0:0.8X�.��5]      �� $��الرتبة��6   $
��Left=�6%   $��540,213,0,0q�6@   $	��Top=�6U   ��6m   Z� ��5^      �� 5_      # �   6&   ��5a      �� 5b      # �   6&   5d      5e        5f   
   $��0,-2,0,2q�6�    6/     *SlideInFromRight+$ 0:0:0.8X�.��5h      &   System.Windows.Controls.DataGrid  $
��Left=�6   $	��191��62   $��RightToLeft=�6?   $��322,293,0,0q�6[   $	��Top=�6p   $	��424��6�   	   Columns	 5i      0  *System.Windows.Controls.DataGridTextColumn  5j      ,  &System.Windows.Controls.DataGridColumn
   Header$8
 2              الاسم كاملاً             ��6)     5k      $
      اللقب      ��6)     5l      $
 الرتبة��6)     5m      $
 عدد الساعات��6)   5p      5q      5r      5s      