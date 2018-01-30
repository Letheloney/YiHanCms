/**
 * @license Copyright (c) 2003-2017, CKSource - Frederico Knabben. All rights reserved.
 * For licensing, see LICENSE.md or https://docs.ckeditor.com/ckeditor4/docs/#!/api/CKEDITOR.config
 */

CKEDITOR.editorConfig = function( config ) {
	// Define changes to default configuration here. For example:
	// config.language = 'fr';
	// config.uiColor = '#AADC6E';
	config.toolbar_Basic = [
							// ��ʾ����
                 ['Source','ShowBlocks','-'],
                //�Ӵ�     б�壬     �»���      ������      �±���        �ϱ���
                ['Bold','Italic','Underline','Strike','Subscript','Superscript'],
				//�ı���ɫ     ������ɫ
                ['TextColor','BGColor'],
                // �����б�          ʵ���б�            ��С����    ��������
                ['NumberedList','BulletedList','-','Outdent','Indent'],
                //��� ��             ���ж���          �Ҷ���          ���˶���
                ['JustifyLeft','JustifyCenter','JustifyRight','JustifyBlock'],
                //������  ȡ�������� ê��
                ['PasteText', 'PasteFromWord', '-', 'Undo', 'Redo','Link','Unlink','Anchor'],
                //ͼƬ    ���       ˮƽ��            ����       �����ַ�        ��ҳ��
                ['Image','Table','HorizontalRule','Smiley','SpecialChar','PageBreak'],
                '/',
                // ��ʽ       ��ʽ      ����    �����С
                ['Styles','Format','Font','FontSize']

             
			];
	// Load toolbar_Name where Name = Basic.
    config.toolbar = 'Basic';
    // Simplify the dialog windows.
    config.removeDialogTabs = 'image:advanced;link:advanced';
    config.disallowedContent = 'img{width,height};img[width,height]';

    	// Se the most common block elements.
    //config.format_tags = 'p;h1;h2;h3;pre';

    config.filebrowserImageUploadUrl = "/FileUpload/Upload";
    
    //�ϴ��ļ�ʱ��������ļ���                                                                                                       
    config.filebrowserBrowseUrl = '/ckfinder/ckfinder.html';
    // �ϴ�ͼƬʱ��������ļ���                                                                                                        
    config.filebrowserImageBrowseUrl = '/ckfinder/ckfinder.html?Type=Images';
    // �ϴ�Flashʱ��������ļ���                                                                                                     
    config.filebrowserFlashBrowseUrl = '/ckfinder/ckfinder.html?Type=Flash';
    // �ϴ��ļ���ť(��ǩ)                                                                                                         
    config.filebrowserUploadUrl = '/ckfinder/core/connector/aspx/connector.aspx?command=QuickUpload&type=Files';
    // �ϴ�ͼƬ��ť(��ǩ)                                                                                                         
    config.filebrowserImageUploadUrl = '/ckfinder/core/connector/aspx/connector.aspx?command=QuickUpload&type=Images';
    // �ϴ�Flash��ť(��ǩ)                                                                                                      
    config.filebrowserFlashUploadUrl = '/ckfinder/core/connector/aspx/connector.aspx?command=QuickUpload&type=Flash';  
};
