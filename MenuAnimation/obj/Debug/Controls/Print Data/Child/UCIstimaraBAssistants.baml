   M S B A M L   `   `   `  ����C  ?Astmara6, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:Astmara6.Controls.Print_Data.Child"Astmara6.Controls.Print_Data.Child  5      #clr-namespace:Astmara6Astmara6  5      >    8Astmara6.Controls.Print_Data.Child.UCIstimaraBAssistants   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Blocal0clr-namespace:Astmara6.Controls.Print_Data.Child     5      +Astmara6clr-namespace:Astmara6     5        � 	Resources  5
         Astmara6.Branches   branches  branchesViewSource �� Source �� Source  1   Astmara6.Teachers  teachers  teachersViewSource��%�   &	        &	      7   &	 B     &	 c     &	 v     7    5   
   6   �� 5   
    6:   �� *	_Branches+8   ��5   
   	#FF3580BF��6%     5   
   6   �� 5   
    6:   �� *	_Teachers+8   5      .��5      �  � DataContext# [ 6   .+�5   
   �� -   5         ��Name$ btnExportData��5      $��استخراح��6C   $
��Left=�6U   $��
11,442,0,0q�6p   $	��Top=�6�   $��94��6�   �� 5   
   -   5        $��اختر الكل��5      $
��Left=�6&   $��
11,382,0,0q�6A   $	��Top=�6U   $��94��6m   6x   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ IstmaraB��5      $
��Left=�6%   $	��327��6@   $��RightToLeft=�6M   $��105,147,0,0q�6i   $	��Top=�6~   $	��651��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 
الاسم��6%     5      $ الدرجة��6%     5      $! النصب القانوني��6%     5      $5 /المواد التي يقوم بتدريسها��6%     5      $ نظري��6%     5      $ عملي��6%     5      $ تمارين��6%     5      $ المجموع ��6%   5(      �� 5)   
   $
��Left=�6   $	��Top=�6+   $��
667,66,0,0q�6C   ��5*      �� 5+       �� Color# �  6"   5-      �� 5.   
   $��حدد الدكتور ��6   $
��Left=�6'   $	��Top=�6B   $��
667,66,0,0q�6Z   ��5/      �� 50      # �  6"   52      �� 53   
   $��
القسم��6   $
��Left=�6    $	��Top=�6;   $��
667,25,0,0q�6S   ��54      �� 55      # �  6"   57      �� 58   
   -   5        	 ��Name$	 _TeachersComboBox��58      
 �� DisplayMemberPath$

 Name��6.   $��456,56,168,392q�6_    �� SelectedValuePath$ Id��6w   $��36��6�   ��6G   �� ��59      �� 5:      .R�5;      $� 5<      5>      �� 5?   
   -   5        $	 _BranchesComboBox��5?      $
 TypeOfBranch��6.   $��33��6O   $��505,18,168,433q�6�   $ Id��6�   ��6[   �� # [ ��5@      �� 5A      .R�5B      $� 5C      5E      5F      5G      