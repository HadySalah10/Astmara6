   M S B A M L   `   `   `  ����C  ?Astmara6, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Astmara6Con.ControlsAstmara6Con.Controls  5      #clr-namespace:Astmara6Astmara6  5      $    Astmara6Con.Controls.UCDoctors   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:Astmara6Con.Controls     5      +Astmara6clr-namespace:Astmara6     5      $	��484��5	      $	��746��6     � 	Resources  5
       
  Color1  1 
 Color2 
 Color3 
 Color4   Astmara6.Teachers  teachers  teachersViewSource �� Source �� Source   Astmara6.WorkHours  	workHours  workHoursViewSource   Astmara6.Rank 	 rank 
 workHoursViewSource1   Astmara6.Branches  branches  branchesViewSource   Astmara6.Subjects  subjects  subjectsViewSource��%�  &	        &	 !     &	 B     &	 e     &	 �     &	 �     &	 �     7  &	 �     &	 �     7  &		 ,    &	
 ?    7 	 &	 n    &	 �    7  &	 �    &	 �    7  ��5   
   	#FF3580BF��6*   ��5   
   	#FF3580BF��6%   ��5   
   Transparent��6,   ��5   
   	#FFF1EFEF��6*   ��5   
   	#FFECE3E3��6*     5   
   6   �� 5   
    6:   �� *	_Teachers+8     5   
   6   �� 5   
    6;   �� *
_WorkHours+8     5   
   6   �� 5   
    6<   �� *	WorkHours+8     5   
   6   �� 5   
    6:   �� *	_Branches+8     5   
   6   �� 5   
    6:   �� *	_Subjects+8   5      .��5      �  � DataContext# [ 6    J� RenderTransformOrigin$ 0.446,0.483&�6=   .+�5   
   �� -   5         ��Name$ cou_name��5      $
��Left=�6$   $��28��6?   $��491,157,0,0q�6K    �� TextWrapping$
 Wrap=�6`   $	��Top=�6t   $	��177��6�   .��6�   ��5      �� 5       �� Color# �  6"   .��5   "   ��5       �� 5!      # �   6"   .��5"   #   5#      �� 5$   
   -   5        $ cou_nic_name��5$      $
��Left=�6(   $��28��6C   $��250,157,0,0q�6O   $
 Wrap=�6d   $	��Top=�6x   $	��138��6�   .��6�   ��5%      �� 5&      # �  6"   .��5'   "   ��5(      �� 5)      # �   6"   .��5*   #   5+      �� 5,   
   $��
اللقب��6   $
��Left=�6    $��393,164,0,0q�6;   $	��Top=�6P   ��6h   Z� ��5-      �� 5.      # �   6"   ��50      �� 51      # �   6"   53      �� 54   
   $��
الاسم��6   $
��Left=�6    $��690,164,0,0q�6;   $	��Top=�6P   ��55      �� 56      # �   6"   58      �� 59   
   -   5        $��
اضافة��59      $
��Left=�6!   $��206,303,0,0q�6<   $	��Top=�6Q   $��68��6i   $��28��6t   ��5:      �� 5;      # �  6"   5=      �� 5>   
   -   5        $��عودة��5>      $
��Left=�6    $��	0,421,0,0q�6;   $	��Top=�6N   $��77��6f   $��29��6q   ��5?      �� 5@      # �  6"   5B      �� 5C   
   -   5        $��التالي��5C      $
��Left=�6"   $��	0,455,0,0q�6=   $	��Top=�6P   $��77��6h   $��29��6s   ��5D      �� 5E      # �  6"   5G      �� 5H   
   $��الرتبة��6   $
��Left=�6!   $��690,213,0,0q�6<   $	��Top=�6Q   ��6i   Z� ��5I      �� 5J      # �   6"   ��5L      �� 5M      # �   6"   5O      �� 5P   
   $��االقسم��6   $
��Left=�6!   $��393,215,0,0q�6<   $	��Top=�6Q   ��6i   Z� ��5Q      �� 5R      # �  6"   5T      �� 5U   
   -   5         ��Name$ degree��5U      
���   �	 �� DisplayMemberPath$
	 Rank��66   $��31��6O   $��491,217,78,236q�6�   
 �� SelectedValuePath$
 Id��6�   ��6[   �� # [
 ��5V      �� 5W      # �  6"   ��5Y      �� 5Z      .R�5[      $� 5\      5^      �� 5_   
   -   5        $ department1��5_      $	 TypeOfBranch��6(   $��31��6I   $��250,217,358,236q�6�   $
 Id��6�   ��6U   �� # [ ��5`      �� 5a      # �  6"   ��5c      �� 5d      .R�5e      $� 5f      5h      �� 5i   
   -   5         ��Name$ BTNEdit��5i      $�� تعديل وحذف��6"   $
��Left=�68   $��155,336,0,0q�6S   $	��Top=�6h   $	��119��6�   $��28��6�   ���	#FF303030���	#FF303030$ 0.583,1.607&�6�   &   System.Windows.Controls.DataGrid  5j   
   -	   5          Name$ _WorkHoursDataGrid��5j         
IsReadOnly .    AutoGenerateColumns .     EnableRowVirtualization . $��RightToLeft=�6|   $��286,286,0,0q�6�      RowDetailsVisibilityMode$ VisibleWhenSelected=�6�   ��6�   �� # [    Columns 5k      0  *System.Windows.Controls.DataGridTextColumn  5l      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6>      
Visibility$ Hidden=�6J      
IsReadOnly .    Width5	  /System.Windows.Controls.DataGridLengthConverter$
 auto	 6p   1
  +System.Windows.Controls.DataGridBoundColumn 
  Binding 6&   �� *Id+6p     5m      $ 
الاسم��6?   $
 auto	 6N    6&   �� *Name+6N     5n      $ 
اللقب��6C   $
 auto	 6R    6&   �� *
NickName+6R     5o      $ Hidden=�6F   $
 auto��6Z   $ SizeToHeader	 6h    6&   �� *IdWorkHours+6h     5p      $ Hidden=�6=   $ Id��6Q    . $ SizeToHeader	 6o    6&   �� *Id+6o     5q      $ الرتبة��6?   $ SizeToHeader	 6O    6&   �� *Rank+6O     5r      $ عدد الساعات��6H   $ SizeToHeader	 6]    6&   �� *HoursOfQuorum+6]   4  .System.Windows.Controls.DataGridCheckBoxColumn  5s      $ Hidden=�6)   $ Academic Or Virtual��6c   $ SizeToHeader	 6�    6=   �� *AcademicOrVirtual+6�   5u      5y      5z      