   M S B A M L   `   `   `  ����C  ?Astmara6, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:Astmara6.Controls.Fixed_Data.Edit!Astmara6.Controls.Fixed_Data.Edit  5      #clr-namespace:Astmara6Astmara6  5      4    .Astmara6.Controls.Fixed_Data.Edit.UCEditDoctor   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Alocal/clr-namespace:Astmara6.Controls.Fixed_Data.Edit     5      +Astmara6clr-namespace:Astmara6     5      -   5          � 	Resources  5
         Astmara6.Teachers   teachers  teachersViewSource �� Source �� Source  1��%�   &	        &	      7   &	 B       5   
   6   �� 5   
    6:   �� *	_Teachers+8   ��5   
   	#FF3580BF��6%   5      .��5      �  � DataContext# [ 6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ _TeachersDataGrid��5      $��RightToLeft=�6.      AutoGenerateColumns .     EnableRowVirtualization . $��400,250,0,0q�6�      RowDetailsVisibilityMode$ VisibleWhenSelected=�6�   ��6�   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Id��6=   
   
Visibility$
 Hidden=�6I      
IsReadOnly .    Width5  /System.Windows.Controls.DataGridLengthConverter$ SizeToHeader 6o   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6&   �� *Id+6o     5      $	 
الاسم��6?   $ SizeToHeader 6N    6&   �� *Name+6N     5      $	 
اللقب��6C   $ SizeToHeader 6R    6&   �� *
NickName+6R     5      $
 Hidden=�6F   $	 Id Work Hours��6Z   $ SizeToHeader 6q    6&   �� *IdWorkHours+6q   5      �� 5   
   -   5         ��Name$ BTNEdit_Copy��5      $��
تعديل��6'   $
��Left=�67   $��329,261,0,0q�6R   $	��Top=�6g   $��66��6   $��28��6�   ���	#FF303030���	#FF303030 J� RenderTransformOrigin$ 0.583,1.607&�6�   �� 5   
   -   5        $ BTNRemove_Copy��5      $��حذف��6)   $
��Left=�67   $��329,294,0,0q�6R   $	��Top=�6g   $��66��6   $��28��6�   ���	#FF303030���	#FF3030306�   �� 5   
   -   5        $ BTNRemoveAll_Copy��5      $��حذف الكل��6,   $
��Left=�6?   $��297,328,0,0q�6Z   $	��Top=�6o   $��98��6�   $��28��6�   ���	#FF303030���	#FF3030306�   �� 5   
   -   5        $��عودة��5      $
��Left=�6    $��
10,411,0,0q�6;   $	��Top=�6O   $��77��6g   $��29��6r   ��5      �� 5       �� Color# �  6"   5!      5"      5#      