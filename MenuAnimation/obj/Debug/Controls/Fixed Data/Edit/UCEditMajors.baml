   M S B A M L   `   `   `  ����C  ?Astmara6, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:Astmara6.Controls.Fixed_Data.Edit!Astmara6.Controls.Fixed_Data.Edit  5      #clr-namespace:Astmara6Astmara6  5      4    .Astmara6.Controls.Fixed_Data.Edit.UCEditMajors   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Alocal/clr-namespace:Astmara6.Controls.Fixed_Data.Edit     5      +Astmara6clr-namespace:Astmara6     5      -   5          � 	Resources  5
         Astmara6.Section   section  sectionsViewSource �� Source �� Source  1��%�   &	        &	      7   &	 A       5   
   6   �� 5   
    6:   �� *
Sections+8   ��5   
   	#FF3580BF��6%   5      .��5      �  � DataContext# [ 6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ sectionsDataGrid��5      $��RightToLeft=�6-      RowDetailsVisibilityMode$ VisibleWhenSelected=�6I   $��400,250,0,0q�6x      EnableRowVirtualization .    AutoGenerateColumns .  ��6�   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 SizeToHeader 6&   
   
IsReadOnly
 .    Header$ Id��6M      
Visibility$ Hidden=�6Y   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6m   �� *Id+  5      $	 SizeToHeader 6&   $ 	Id Branch��6;   $ Hidden=�6N    6b   �� *
IdBranch+  5      $	 SizeToHeader 6&   $ 
الشعب��6;    6J   �� *Name+5      �� 5   
   -   5         ��Name$ BTNEdit��5      $��
تعديل��6"   $
��Left=�62   $��569,260,0,0q�6M   $	��Top=�6b   $��66��6z   $��28��6�   ���	#FF303030���	#FF303030 J� RenderTransformOrigin$ 0.583,1.607&�6�   �� 5   
   -   5        $ 	BTNRemove��5      $��حذف��6$   $
��Left=�62   $��503,260,0,0q�6M   $	��Top=�6b   $��66��6z   $��28��6�   ���	#FF303030���	#FF3030306�   �� 5   
   -   5        $ BTNRemoveAll��5      $��حذف الكل��6'   $
��Left=�6:   $��405,260,0,0q�6U   $	��Top=�6j   $��98��6�   $��28��6�   ���	#FF303030���	#FF3030306�   �� 5   
   -   5        $ BTNBack��5      $��عودة��6"   $
��Left=�61   $��
0,411,0,10q�6L   $��77��6`   $
��Auto��6k   ��5      �� 5       �� Color# �  6"   5      5!      5"      