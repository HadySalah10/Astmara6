   M S B A M L   `   `   `  ����C  ?Astmara6, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Astmara6ConAstmara6Con  5      #clr-namespace:Astmara6Astmara6  5          Astmara6Con.UCLevels   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:Astmara6Con     5      +Astmara6clr-namespace:Astmara6     5      -   5        $	��484��5	      $	��746��6     � 	Resources  5
         1  2   Astmara6.Levels 
 levels  levelsViewSource �� Source �� Source��%�   &	        &	 !     &	 B     &	 U     7  ��5   
   	#FF3580BF��6%   ��5   
   	#FFECE3E3��6%     5   
   6   �� 5   
    68   �� *	_Levels+8   5      .��5      �  � DataContext# [ 6   .+�5   
   �� $��اسم المستوي��6   $
��Left=�6&   $��660,188,0,0q�6A   $	��Top=�6V   ��6n   Z� ��5      �� 5       �� Color# �   6"   5      �� 5   
   -   5         ��Name$ TBNameLevels��5      $
��Left=�6T   $��22��6o   $��510,192,0,0q�6{    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��120��6�   ���	#FFECE3E3.��6  ��5      �� 5      # �   6"   .��5   #   5      �� 5   
   -   5         ��Name$ BTNNext��5      $��التالي��6"   $
��Left=�63   $��	0,445,0,0q�6N   $	��Top=�6a   $��77��6y   $��29��6�   ��5      �� 5      # �   6"   5       �� 5!   
   -   5        $ BTNAdd��5!      $��
اضافة��6!   $
��Left=�61   $��396,192,0,0q�6L   $	��Top=�6a   $��68��6y   $��28��6�    J� RenderTransformOrigin$ 0.934,0.321&�6�   ��5"      �� 5#      # �   6"   5%      �� 5*   
   -   5        $ BTNBack��5*      $��العودة��6"   $
��Left=�63   $��	2,400,0,0q�6N   $��75��6a   $ -0.635,0.598&�6m   $��32��6�   $	��Top=�6�   &   System.Windows.Controls.DataGrid  5+   
   -   5        	  Name$	 DGLevelsView��5+      $��RightToLeft=�6)   
   AutoGenerateColumns
 .     EnableRowVirtualization . $��308,225,0,1q�6�      RowDetailsVisibilityMode$ VisibleWhenSelected=�6�   ��6�   ��    Columns 5,      0  *System.Windows.Controls.DataGridTextColumn  5-      ,  &System.Windows.Controls.DataGridColumn   
Visibility$ Hidden=�6=      Header$ Id��6Q      
IsReadOnly .    Width5  /System.Windows.Controls.DataGridLengthConverter$ SizeToHeader 6o   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6&   �� *Id+6o     5.      $ المستويات��6?   $
 auto 6R    6&   �� *Name+6R   50      �� 51   
   -   5        $ 	BTNRemove��51      $��حذف��6$   $
��Left=�62   $��493,235,0,0q�6M   $	��Top=�6b   $��66��6z   $��28��6�   ���	#FF303030���	#FF3030306�   �� 52   
   -   5        $ BTNEdit��52      $��
تعديل��6"   $
��Left=�62   $��564,235,0,0q�6M   $	��Top=�6b   $��66��6z   $��28��6�   ���	#FF303030���	#FF303030$ 0.583,1.607&�6�   �� 53   
   -	   5        $ BTNRemoveAll��53      $��حذف الكل��6'   $
��Left=�6:   $��366,235,0,0q�6U   $	��Top=�6j   $��98��6�   $��28��6�   ���	#FF303030���	#FF3030306�   54      55      