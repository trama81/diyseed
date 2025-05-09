﻿using System.Collections.Generic;
using System.Linq;
using PdfSharpCore;
using PdfSharpCore.Drawing;

namespace Diyseed.Core
{
    public static class Configuration
    {
        ///////////////////
        // DOCUMENT STRINGS
        public static readonly string DOUMENT_FILENAME = "DIYseed_net-{0}words-{1}cards-{2}x{3}mm";
        public static readonly string DOUMENT_TITLE = "Protect your crypto-wallet seed backup - DIYseed.net";
        public static readonly string DOUMENT_FOOTER_TEXT = "generated by DIYseed.net";
        public static readonly string DOUMENT_WRITER_HEADER_TEXT = "Marking stencil";
        public static readonly string DOUMENT_READER_HEADER_TEXT = "Reading stencil";
        public static readonly string DOUMENT_MANUAL_HEADER_TEXT = "Manual";

        ////////////////
        // DOCUMENT SIZE
        public static readonly PageSize DOCUMENT_FORMAT = PageSize.A4;
        public static readonly XSize DOCUMENT_SIZE = new XSize(XUnit.FromMillimeter(210), XUnit.FromMillimeter(297));
        public static readonly XUnit DOCUMENT_MARGIN_TOP = XUnit.FromMillimeter(20);
        public static readonly XUnit DOCUMENT_MARGIN_H = XUnit.FromMillimeter(15);
        public static readonly XUnit DOCUMENT_MARGIN_BOTTOM = XUnit.FromMillimeter(10);
        public static readonly XSize EFFECTIVE_PAGE_SIZE = new XSize(DOCUMENT_SIZE.Width - 2 * DOCUMENT_MARGIN_H, DOCUMENT_SIZE.Height - DOCUMENT_MARGIN_TOP - DOCUMENT_MARGIN_BOTTOM);

        //////////////////////////
        // DOCUMENT VISUAL SETTING
        public const string DOCUMENT_FONT_FAMILY = "Calibri";
        public static readonly XPen DOCUMENT_PEN_THIN = new XPen(XColors.Black, 0.1);
        public static readonly XPen DOCUMENT_PEN_NORMAL = new XPen(XColors.Black, 0.3);
        public static readonly XPen DOCUMENT_PEN_THICK = new XPen(XColors.Black, 0.5);
        public static XPen RED_DOTTED_PEN
        {
            get
            {
                var pen = new XPen(XColors.Red, 0.6);
                pen.DashStyle = XDashStyle.Dot;
                return pen;
            }
        }

        /////////
        // HEADER
        public static readonly XUnit DOCUMENT_HEADER_HEIGHT = XUnit.FromMillimeter(20);
        public static readonly XFont HEADER_FONT = new XFont(DOCUMENT_FONT_FAMILY, 20, XFontStyle.Bold);
        public static readonly XBrush HEADER_FONT_BRUSH = new XSolidBrush(XColor.FromArgb(255, 0, 0, 0));

        /////////
        // FOOTER
        public static readonly XFont FOOTER_FONT = new XFont(DOCUMENT_FONT_FAMILY, 9, XFontStyle.Regular);
        public static readonly XBrush FOOTER_FONT_BRUSH = new XSolidBrush(XColor.FromArgb(100, 0, 0, 0));

        ///////////////////
        // WRITER GENERATOR
        public static readonly XUnit CARD_MARGIN = XUnit.FromMillimeter(4);
        public static readonly string GRID_FONT_NAME = DOCUMENT_FONT_FAMILY;
        // cell properties
        public static readonly (double, double) CELL_FONT_SIZE_RANGE = (2.2, 12);
        public static readonly XFontStyle CELL_FONT_STYLE = XFontStyle.Regular;
        public static readonly XBrush CELL_FONT_BRUSH = new XSolidBrush(XColor.FromArgb(200, 0, 0, 0));
        // words properties
        public static readonly (double, double) WORD_NR_FONT_SIZE_RANGE = (10, 35);
        public static readonly XFontStyle WORD_NR_FONT_STYLE = XFontStyle.Bold;
        public static readonly XBrush WORD_NR_FONT_BRUSH = new XSolidBrush(XColor.FromArgb(100, 0, 0, 0));
        public static readonly XBrush WORD_CELL_SHADE_BRUSH = new XSolidBrush(XColor.FromArgb(20, 0, 0, 0));

        //////////////////
        // READER GRAPHICS
        // reader strings
        public static readonly string READER_CUTLINE_TEXT = "Cut the red line";
        public static readonly string READER_INSERT_ARROW_TEXT = "Insert the backup card";
        public static readonly string READER_TEXTBOXES_TITLE_TEXT = "Seed words from card nr. {0}";

        public static readonly XUnit READER_LINE_SEPARATOR_WIDTH = XUnit.FromMillimeter(5);
        public static readonly XPen READER_LINE_SEPARATOR_PEN = DOCUMENT_PEN_THIN;
        public static readonly XUnit READER_ENCODING_CHARS_OFFSET = XUnit.FromMillimeter(1.5);
        public static readonly XUnit READER_GUIDELINE_OVERFLOW = XUnit.FromMillimeter(5);
        public static readonly XPen READER_GUIDELINE_PEN = DOCUMENT_PEN_THICK;
        // cutline properties
        public static readonly XUnit READER_CUTLINE_OVERFLOW = XUnit.FromMillimeter(1);
        public static readonly XUnit READER_CUTLINE_ARROW_IMG_SIZE = XUnit.FromMillimeter(7);
        public static readonly XFont READER_CUTLINE_FONT = new XFont(DOCUMENT_FONT_FAMILY, 6, XFontStyle.Bold);
        // insert arrow properties
        public static readonly XUnit READER_INSERT_ARROW_SIZE = XUnit.FromMillimeter(20);
        public static readonly XFont READER_INSERT_ARROW_FONT = new XFont(DOCUMENT_FONT_FAMILY, 13, XFontStyle.Bold);

        ///////////////////
        // READER TEXTBOXES
        public static readonly XSize READER_TEXTBOX_CELL_SIZE = new XSize(XUnit.FromMillimeter(6), XUnit.FromMillimeter(6));
        public static readonly XSize READER_TEXTBOX_SIZE = new XSize(READER_TEXTBOX_CELL_SIZE.Width * 4, READER_TEXTBOX_CELL_SIZE.Height);
        public static readonly XPen READER_TEXTBOX_OUTLINE_PEN = DOCUMENT_PEN_THICK;
        public static readonly XPen READER_TEXTBOX_VERTICAL_LINES_PEN = DOCUMENT_PEN_NORMAL;
        // card number
        public static readonly XSize READER_TEXTBOX_CARD_NR_SIZE = new XSize(XUnit.FromMillimeter(150), READER_TEXTBOX_CELL_SIZE.Height * 2);
        public static readonly XFont READER_TEXTBOX_CARD_NR_FONT = new XFont(DOCUMENT_FONT_FAMILY, 13, XFontStyle.Regular);
        public static readonly XBrush READER_TEXTBOX_CARD_NR_BRUSH = new XSolidBrush(XColor.FromArgb(160, 0, 0, 0));
        // textbox number
        public static readonly XFont READER_TEXTBOX_NR_FONT = new XFont(DOCUMENT_FONT_FAMILY, 10, XFontStyle.Regular);

        ///////////////
        // INPUT RANGES
        public static readonly IEnumerable<int> SEED_LENGTH_RANGE = Enumerable.Range(10, 30);
        public static readonly IEnumerable<int> CARD_COUNT_RANGE = Enumerable.Range(1, 13);
        public static readonly (XUnit, XUnit) CARD_WIDTH_RANGE = (XUnit.FromMillimeter(20), DOCUMENT_SIZE.Width - DOCUMENT_MARGIN_H * 2);
        public static readonly (XUnit, XUnit) CARD_HEIGHT_RANGE = (XUnit.FromMillimeter(20), CARD_WIDTH_RANGE.Item2);
        //
        public static readonly IEnumerable<int> CARD_SPLIT_RANGE = Enumerable.Range(1, 5);
        public static readonly IEnumerable<EncodingType> CARDS_ENCODING_RANGE = new EncodingType[] { EncodingType.Alphabet, EncodingType.Number };
        public static readonly (XUnit, XUnit) CARDS_RADIUS_RANGE = (0, XUnit.FromMillimeter(5));
        public static readonly (XUnit, XUnit) CARDS_PADDING_RANGE = (0, XUnit.FromMillimeter(5));
        public static readonly IEnumerable<int> WRITER_COPIES_RANGE = Enumerable.Range(1, 10);

        /////////////////
        // INPUT DEFAULTS
        public static readonly int SEED_LENGTH_DEFAULT = 24;
        public static readonly int CARD_COUNT_DEFAULT = 2;
        public static readonly XSize CARD_SIZE_DEFAULT = new XSize(XUnit.FromMillimeter(100), XUnit.FromMillimeter(60));
        //
        public static readonly int CARD_SPLIT_DEFAULT = 1;
        public static readonly EncodingType CARDS_ENCODING_DEFAULT = EncodingType.Alphabet;
        public static readonly XUnit CARDS_RADIUS_DEFAULT = XUnit.FromMillimeter(1.5);
        public static readonly XUnit CARDS_PADDING_DEFAULT = XUnit.FromMillimeter(1.5);
        public static readonly int WRITER_COPIES_DEFAULT = 1;
        public static readonly PdfSectionFlags SECTIONS_DEFAULT = PdfSectionFlags.Writer | PdfSectionFlags.Reader | PdfSectionFlags.Manual;
    }
}
