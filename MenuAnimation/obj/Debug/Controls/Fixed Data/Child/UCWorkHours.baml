   M S B A M L   `   `   `  ����C  ?Astmara6, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Astmara6Con.ControlsAstmara6Con.Controls  5      #clr-namespace:Astmara6Astmara6  5      &     Astmara6Con.Controls.UCWorkHours   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:Astmara6Con.Controls     5      +Astmara6clr-namespace:Astmara6     5      $	��484��5	      $	��746��6     � 	Resources  5
         1   Astmara6.WorkHours  	workHours  workHoursViewSource �� Source �� Source��%�   &	        &	 !     &	 4     7  ��5   
   	#FF3580BF��6%     5   
   6   �� 5   
    6;   �� *
_WorkHours+8   5      .��5      �  � DataContext# [ 6   .+�5   
   �� -   5         ��Name$ TBRank��5      $
��Left=�6"   $��31��6h   $��553,212,0,0q�6t    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $��91��6�   ���	#FFECE3E3.��6�   ��5      �� 5       �� Color# �   6"   .��5   #   5      �� 5   
   $��الرتبة��6   $
��Left=�6!   $	��Top=�6<   $��676,214,0,0q�6T   $��29��6i   $��70��6u   ��5      �� 5      # �   6"   5      �� 5   
   -   5        $ TBHoursOfQuorum��5      $
��Left=�6W   $��31��6r   $��132,212,0,0q�6~   $
 Wrap=�6�   $	��Top=�6�   $��96��6�   ���	#FFECE3E3.��6�   ��5      �� 5      # �   6"   .��5   #   5      �� 5    
   $"��عدد ساعات العمل��6   $
��Left=�6*   $	��Top=�6E   $��249,214,0,0q�6]   $��29��6r   $	��102��6~   ��5!      �� 5"      # �   6"   5$      �� 5%   
   -   5         ��Name$ BTNAdd��5%      $��
اضافة��6!   $
��Left=�61   $��229,283,0,0q�6L   $	��Top=�6a   $��88��6y   $��28��6�   ��5&      �� 5'      # �   6"   5)      �� 5*   
   -   5        $ BTNBack��5*      $��عودة��6"   $
��Left=�61   $��	0,421,0,0q�6L   $	��Top=�6_   $��77��6w   $��29��6�   ��5+      �� 5,      # �   6"   5.      �� 5/   
   -   5        $ BTNNext��5/      $��التالي��6"   $
��Left=�63   $��	0,455,0,0q�6N   $��77��6a   $��29��6l   $	��Top=�6�   ��50      �� 51      # �   6"   53      	� 54   
   -   5         	�Name$ Paper��54      $��نظري��6&   $
��Left=�65   $��460,255,0,0q�6P   $	��Top=�6e   ���	#FF3580BF6�   	� 55   
   -   5        $ Virtual��55      $��عملي��6'   $
��Left=�66   $��364,255,0,0q�6Q   $	��Top=�6f   ���	#FF3580BF6~   &   System.Windows.Controls.DataGrid  56   
   -   5        	  Name$	 DGWorkHoursView��56      $��RightToLeft=�6,   
   AutoGenerateColumns
 .     EnableRowVirtualization . $��322,283,0,1q�6�      RowDetailsVisibilityMode$ VisibleWhenSelected=�6�   ��6�   ��    Columns 57      0  *System.Windows.Controls.DataGridTextColumn  58      -	   5        idColumn��,  &System.Windows.Controls.DataGridColumn   
Visibility$ Hidden=�58   N      Header$ Id��6b      
IsReadOnly .    Width5  /System.Windows.Controls.DataGridLengthConverter$ SizeToHeader 6�   1  +System.Windows.Controls.DataGridBoundColumn   Binding 67   �� *Id+6�     59      -
   5        
rankColumn��$ ألرتبة��59   R   $ SizeToHeader 6b    69   �� *Rank+6b     5:      -   5        hoursOfQuorumColumn��$# النصاب القانوني��5:   d   $ SizeToHeader 6}    6B   �� *HoursOfQuorum+6}   4  .System.Windows.Controls.DataGridCheckBoxColumn  5;      -   5        academicOrVirtualColumn��$ Hidden=�5;   J   $ Academic Or Virtual��6�   $ SizeToHeader 6�    6^   �� *AcademicOrVirtual+6�   5>      �� 5?   
   -   5        $ BTNEdit��5?      $��
تعديل��6"   $
��Left=�62   $��498,294,0,0q�6M   $	��Top=�6b   $��67��6z   $��28��6�   ���	#FF303030���	#FF303030 J� RenderTransformOrigin$ 0.583,1.607&�6�   �� 5@   
   -   5        $ BTNRemoveAll��5@      $��حذف الكل��6'   $
��Left=�6:   $��331,294,0,0q�6U   $	��Top=�6j   $��98��6�   $��28��6�   ���	#FF303030���	#FF3030306�   �� 5A   
   -   5        $ 	BTNRemove��5A      $��حذف��6$   $
��Left=�62   $��429,294,0,0q�6M   $	��Top=�6b   $��64��6z   $��28��6�   ���	#FF303030���	#FF3030306�   5B      5C      