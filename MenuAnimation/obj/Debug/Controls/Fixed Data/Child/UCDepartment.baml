   M S B A M L   `   `   `  ����C  ?Astmara6, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Astmara6Con.ControlsAstmara6Con.Controls  5      #clr-namespace:Astmara6Astmara6  5      '    !Astmara6Con.Controls.UCDepartment   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:Astmara6Con.Controls     5      +Astmara6clr-namespace:Astmara6     5      $	��484��5	      $	��746��6     � 	Resources  5
         1   Astmara6.Branches  branches  branchesViewSource �� Source �� Source��%�   &	        &	 !     &	 4     7  ��5   
   	#FF3580BF��6%     5   
   6   �� 5   
    6:   �� *	_Branches+8   5      .��5      �  � DataContext# [ 6   .+�5   
   �� $��اسم القسم��6   $
��Left=�6$   $��646,224,0,0q�6?   $	��Top=�6T   ��6l   Z� ��5      �� 5       �� Color# �   6"   5      �� 5   
   -   5         ��Name$ TBNameDepartment��5      $��RightToLeft=�6W   $��Right=�6s   $��23��6�   $��0,0,137,232q�6�    �� TextWrapping$
 Wrap=�6�   $��Bottom=�6�   $	��120��6�   ���	#FFECE3E3.��6  ��5      �� 5      # �   6"   .��5   #   5      �� 5   
   -   5         ��Name$ BTNBack��5      $��عودة��6"   $��Right=�61   $��
0,0,669,37q�6M   $��Bottom=�6a   $��77��6|   $��29��6�   ��5      �� 5      # �   6"   5      �� 5    
   -   5        $ BTNNext��5       $��التالي��6"   $
��Left=�63   $��	0,452,0,0q�6N   $	��Top=�6a   $��77��6y   $��29��6�   ��5!      �� 5"      # �   6"   5$      �� 5%   
   -   5        $ BTNAdd��5%      $��
اضافة��6!   $��Right=�61   $��0,0,262,227q�6M   $��Bottom=�6b   $��68��6}   $��28��6�   ��5&      �� 5'      # �   6"   5)      &   System.Windows.Controls.DataGrid  5*   
   -   5          Name$ DGDepartmentView��5*      $��RightToLeft=�6-   	   AutoGenerateColumns	 .  
   EnableRowVirtualization
 . $��346,284,0,0q�6�      RowDetailsVisibilityMode$ VisibleWhenSelected=�6�   ��6�   ��    Columns 5+      0  *System.Windows.Controls.DataGridTextColumn  5,      ,  &System.Windows.Controls.DataGridColumn   
Visibility$ Hidden=�6>      Header$ Id��6R      Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 6_   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6'   �� *Id+6_     5-      $ الاقسام��6H   $
 Auto 6Y    6&   �� *TypeOfBranch+6Y   5/      �� 50   
   -   5        $ BTNEdit��50      $��
تعديل��6"   $
��Left=�62   $��515,294,0,0q�6M   $	��Top=�6b   $��66��6z   $��28��6�   ���	#FF303030���	#FF303030 J� RenderTransformOrigin$ 0.583,1.607&�6�   �� 51   
   -   5        $ 	BTNRemove��51      $��حذف��6$   $
��Left=�62   $��449,294,0,0q�6M   $	��Top=�6b   $��66��6z   $��28��6�   ���	#FF303030���	#FF3030306�   �� 52   
   -   5        $ BTNRemoveAll��52      $��حذف الكل��6'   $
��Left=�6:   $��346,294,0,0q�6U   $	��Top=�6j   $��98��6�   $��28��6�   ���	#FF303030���	#FF3030306�   54      55      